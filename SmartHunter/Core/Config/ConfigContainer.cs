﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace SmartHunter.Core.Config
{
    public class ConfigContainer<T> : FileContainer
    {
        public T Values = (T)Activator.CreateInstance(typeof(T), new object[] { });

        public event EventHandler Loaded;

        public ConfigContainer(string fileName) : base(fileName)
        {
            bool isDesignInstance = System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime;
            if (!isDesignInstance)
            {
                Load();
            }
        }

        public void HandleDeserializationError(object sender, Newtonsoft.Json.Serialization.ErrorEventArgs args)
        {
            Log.WriteException(args.ErrorContext.Error);
            args.ErrorContext.Handled = true;
        }
        
        override protected void OnChanged()
        {
            Load();
        }

        void Load()
        {
            if (File.Exists(FullPathFileName))
            {
                try
                {
                    string contents = null;
                    using (FileStream stream = File.Open(FullPathFileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        using (StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8))
                        {
                            contents = reader.ReadToEnd();
                        }
                    }

                    var settings = new JsonSerializerSettings();
                    settings.Formatting = Formatting.Indented;
                    settings.ContractResolver = new ContractResolver();
                    settings.Error = HandleDeserializationError;

                    // Solves dictionary/lists being added to instead of overwritten but causes problems elsewhere
                    // https://stackoverflow.com/questions/29113063/json-net-why-does-it-add-to-list-instead-of-overwriting
                    // https://stackoverflow.com/questions/27848547/explanation-for-objectcreationhandling-using-newtonsoft-json
                    // This has been moved to ContractResolver to target Dictionaries specifically
                    // settings.ObjectCreationHandling = ObjectCreationHandling.Replace;
                    settings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
                    settings.Converters.Add(new StringFloatConverter());

                    JsonConvert.PopulateObject(contents, Values, settings);

                    Log.WriteLine($"{FileName} loaded");
                }
                catch (Exception ex)
                {
                    Log.WriteException(ex);
                }
            }
            else
            {
                Save();
            }

            if (Loaded != null)
            {
                Loaded(this, null);
            }
        }

        public void Save()
        {
            TryPauseWatching();

            try
            {
                var settings = new JsonSerializerSettings();
                settings.Formatting = Formatting.Indented;
                settings.NullValueHandling = NullValueHandling.Ignore;
                settings.ContractResolver = new ContractResolver();

                settings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
                settings.Converters.Add(new StringFloatConverter());

                var jsonString = JsonConvert.SerializeObject(Values, settings);

                File.WriteAllText(FullPathFileName, jsonString);

                Log.WriteLine($"{FileName} saved");
            }
            catch (Exception ex)
            {
                Log.WriteException(ex);
            }

            TryUnpauseWatching();
        }
    }
}