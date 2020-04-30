using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.AccessControl;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using SmartHunter.Core;
using SmartHunter.Core.Helpers;
using SmartHunter.Core.Windows;
using SmartHunter.Game.Data;
using SmartHunter.Game.Data.ViewModels;
using SmartHunter.Game.Data.WidgetContexts;
using SmartHunter.Game.Helpers;
using System.IO;
using System.Net.Http;
using System.Text;

using Newtonsoft.Json;

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
            else if (control == InputControl.CopyTeamDamage && isDown)
            {
                string str = "";
                List<Player> players = OverlayViewModel.Instance.TeamWidget.Context.Players.ToList();
                if (OverlayViewModel.Instance.TeamWidget.Context.Players.Count > 0)
                {
                    players.Sort();
                    foreach (var player in players)
                        str += String.Format("{0} {1}% ", player.Name.Length >= 3 ? player.Name.Substring(0, 3) : player.Name, (player.DamageFraction * 100).ToString("0.##"));
                }
                else
                    str = "No Team Damage";
                CopyToClipboard(str);
            }
            else if (control == InputControl.CopyPlayer1Damage && isDown)
            {
                GetPlayerDamage(OverlayViewModel.Instance.TeamWidget.Context.Players, 1);
            }
            else if (control == InputControl.CopyPlayer2Damage && isDown)
            {
                GetPlayerDamage(OverlayViewModel.Instance.TeamWidget.Context.Players, 2);
            }
            else if (control == InputControl.CopyPlayer3Damage && isDown)
            {
                GetPlayerDamage(OverlayViewModel.Instance.TeamWidget.Context.Players, 3);
            }
            else if (control == InputControl.CopyPlayer4Damage && isDown)
            {
                GetPlayerDamage(OverlayViewModel.Instance.TeamWidget.Context.Players, 4);
            }
        }

        private void GetPlayerDamage(Collection<Player> players, int index)
        {
            List<Player> mplayer = players.ToList();
            mplayer.Sort();
            if (mplayer.Count >= index)
                CopyToClipboard(mplayer[index - 1].ToString());
            else
                CopyToClipboard(String.Format("Player Not Found (Index: {0})", index));
        }

        private void CopyToClipboard(String str)
        {
            Clipboard.SetText(str);
            Log.WriteLine("Copy to clipboard > " + str);
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
