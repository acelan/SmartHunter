using SmartHunter.Core;
using SmartHunter.Core.Helpers;
using SmartHunter.Core.Windows;
using SmartHunter.Game.Data.ViewModels;
using SmartHunter.Game.Helpers;
using System;
using System.IO;
using System.Net.Http;
using System.Text;

using System.Linq;
using System.Windows;
using System.Windows.Input;
using SmartHunter.Game.Data;
using Newtonsoft.Json;

namespace SmartHunter.Game
{
    public class MhwOverlay : Overlay
    {
        MhwMemoryUpdater m_MemoryUpdater;

        protected override bool ShowWindows
        {
            get
            {
                return ConfigHelper.Main.Values.Overlay.ShowWindows;
            }
        }

        public MhwOverlay(Window mainWindow, params WidgetWindow[] widgetWindows) : base(mainWindow, widgetWindows)
        {
            ConfigHelper.Main.Loaded += (s, e) => { UpdateWidgetsFromConfig(); };
            ConfigHelper.Localization.Loaded += (s, e) => { RefreshWidgetsLayout(); };
            ConfigHelper.MonsterData.Loaded += (s, e) => { RefreshWidgetsLayout(); };
            ConfigHelper.PlayerData.Loaded += (s, e) => { RefreshWidgetsLayout(); };

            if (!ConfigHelper.Main.Values.Debug.UseSampleData)
            {
                m_MemoryUpdater = new MhwMemoryUpdater();
            }
        }

        protected override void InputReceived(Key key, bool isDown)
        {
            foreach (var controlKeyPair in ConfigHelper.Main.Values.Keybinds.Where(keybind => keybind.Value == key))
            {
                HandleControl(controlKeyPair.Key, isDown);
            }
        }

        private void HandleControl(InputControl control, bool isDown)
        {
            if (control == InputControl.ManipulateWidget && isDown && !OverlayViewModel.Instance.CanManipulateWindows)
            {
                OverlayViewModel.Instance.CanManipulateWindows = true;

                if (!ShowWindows)
                { 
                    // Make all the windows selectable
                    foreach (var widgetWindow in WidgetWindows)
                    {
                        WindowHelper.SetTopMostSelectable(widgetWindow as Window);
                    }
                }
            }
            else if (control == InputControl.ManipulateWidget && !isDown && OverlayViewModel.Instance.CanManipulateWindows)
            {
                OverlayViewModel.Instance.CanManipulateWindows = false;

                bool canSaveConfig = false;

                // Return all windows to their click through state
                foreach (var widgetWindow in WidgetWindows)
                {
                    if (!ShowWindows)
                    {
                        WindowHelper.SetTopMostTransparent(widgetWindow as Window);
                    }

                    if (widgetWindow.Widget.CanSaveConfig)
                    {
                        canSaveConfig = true;
                        widgetWindow.Widget.CanSaveConfig = false;
                    }
                }

                if (canSaveConfig)
                {
                    ConfigHelper.Main.Save();
                }
            }
            else if (control == InputControl.HideWidgets)
            {
                OverlayViewModel.Instance.HideWidgetsRequested = isDown;
            }
            else if (control == InputControl.SendDataToDiscord && isDown)
            {
                // Build the body with info from the MhwHelper

                String teamInfo = "";

                foreach( Player player in MhwHelper.TeamInfo.TeamList)
                {
                    int damage = player.Damage;
                    int damageFraction = (int)(player.DamageFraction*100);
                    double damagePerSecond = player.DamagePerSecond;

                    teamInfo += "\n" + player.Name + " " + damage + " (" + damageFraction + "%) DPS: " + damagePerSecond;
                }

                if (teamInfo == "")
                {
                    teamInfo = "\nThere is no player data yet.\n";
                }

                var monsterName = "";
                if (OverlayViewModel.Instance.MonsterWidget.Context.Monsters.Any())
                {
                    var monsterId = OverlayViewModel.Instance.MonsterWidget.Context.Monsters.ElementAt(0).Id;
                    Log.WriteLine("monster id = " + monsterId);
                    monsterName = LocalizationHelper.GetMonsterName(monsterId);
                }
                String body = "```Damage Meter(" + monsterName + ")" + teamInfo + "```";
                this.post(body);
            }
        }


        public void post(string body)
        {            
            String uri = Env.serverUrl+Env.serverPort+Env.serverRouteDamages;

            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), uri))
                {
                    var mydata = new
                    {
                        username = "MHW_BOT",
                        content = body
                    };

                    request.Content = new StringContent(JsonConvert.SerializeObject(mydata), Encoding.UTF8, "application/json");
                    var response = httpClient.SendAsync(request).Result.ToString();
                    Log.WriteLine(response);
                }
            }

        }
    }
}
