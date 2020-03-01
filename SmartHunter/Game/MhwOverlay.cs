using System.Linq;
using System.Windows;
using System.Windows.Input;
using SmartHunter.Core;
using SmartHunter.Core.Helpers;
using SmartHunter.Core.Windows;
using SmartHunter.Game.Data.ViewModels;
using SmartHunter.Game.Helpers;
using System;
using System.IO;
using System.Net.Http;
using System.Text;

using SmartHunter.Game.Data;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;

namespace SmartHunter.Game
{
    public class MhwOverlay : Overlay
    {
        MhwMemoryUpdater m_MemoryUpdater;

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

        private async void HandleControl(InputControl control, bool isDown)
        {
            if (control == InputControl.ManipulateWidget && isDown && !OverlayViewModel.Instance.CanManipulateWindows)
            {
                OverlayViewModel.Instance.CanManipulateWindows = true;

                // Make all the windows selectable
                foreach (var widgetWindow in WidgetWindows)
                {
                    WindowHelper.SetTopMostSelectable(widgetWindow as Window);
                }
            }
            else if (control == InputControl.ManipulateWidget && !isDown && OverlayViewModel.Instance.CanManipulateWindows)
            {
                OverlayViewModel.Instance.CanManipulateWindows = false;

                bool canSaveConfig = false;

                // Return all windows to their click through state
                foreach (var widgetWindow in WidgetWindows)
                {
                    WindowHelper.SetTopMostTransparent(widgetWindow as Window);

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
                    double currentDPS = player.CurrentDPS, dps = player.DamagePerSecond;

                    teamInfo += "\n" + player.Name + " " + damage + " (" + damageFraction + "%) DPS: " + currentDPS.ToString("F2") + "(" + dps.ToString("F2") + ")";
                }

                var monsterName = "";
                if (OverlayViewModel.Instance.MonsterWidget.Context.Monsters.Any())
                {
                    var len = OverlayViewModel.Instance.MonsterWidget.Context.Monsters.Count;
                    var monsterId = OverlayViewModel.Instance.MonsterWidget.Context.Monsters.ElementAt(len-1).Id;

                    while (len > 0)
                    {
                        len -= 1;
                        if (monsterName == "")
                            monsterName = LocalizationHelper.GetMonsterName(monsterId);
                        else
                        {
                            monsterId = OverlayViewModel.Instance.MonsterWidget.Context.Monsters.ElementAt(len).Id;
                            monsterName = monsterName + " + " + LocalizationHelper.GetMonsterName(monsterId);
                        }
                        Log.WriteLine("monster id = " + monsterId + ", name = " + LocalizationHelper.GetMonsterName(monsterId));
                    }

                    Log.WriteLine("monster id = " + monsterId);
                }

                if (teamInfo == "")
                {
                    List<Player> players = OverlayViewModel.Instance.DebugWidget.Context.CurrentGame.SessionPlayers;

                    teamInfo = $"\n======================================({players.Count}/16)\n";

                    string format = "{0,-16} MR: {1,-5} HR: {2,-5}";
                    foreach (Player player in players)
                        teamInfo = teamInfo + string.Format(format, player.Name, player.MR, player.HR) + "\n";
                }

                String currentPlayer = OverlayViewModel.Instance.DebugWidget.Context.CurrentGame.CurrentPlayerName;
                String sessionID = OverlayViewModel.Instance.DebugWidget.Context.CurrentGame.SessionID;
                String body = $"```Damage Meter({monsterName}) {currentPlayer} ({sessionID}){teamInfo}```";
                await this.postAsync(body);
            }
        }


        public async System.Threading.Tasks.Task postAsync(string body)
        {            
            String uri = Env.serverUrl+Env.serverPort+Env.serverRouteDamages;
#if DEBUG
            Log.WriteLine("uri = " + uri);
            Log.WriteLine("body = " + body);
#endif
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
                    var response = await httpClient.SendAsync(request);
                }
            }

        }
    }
}
