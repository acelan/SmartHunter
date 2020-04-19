using System;
using System.Collections.ObjectModel;
using System.Linq;
using SmartHunter.Core;
using SmartHunter.Core.Data;
using SmartHunter.Game.Data.ViewModels;
using SmartHunter.Game.Helpers;

namespace SmartHunter.Game.Data.WidgetContexts
{
    public class TeamWidgetContext : WidgetContext
    {
        public Collection<Player> Players { get; private set; }
        public ObservableCollection<Player> Fake_Players { get; private set; } // TODO: Can dis be done inside the xaml file?

        bool m_DontShowIfAlone = false;
        public bool DontShowIfAlone
        {
            get { return m_DontShowIfAlone; }
            set { SetProperty(ref m_DontShowIfAlone, value); }
        }

        bool m_ShowBars = true;
        public bool ShowBars
        {
            get { return m_ShowBars; }
            set { SetProperty(ref m_ShowBars, value); }
        }

        bool m_ShowNumbers = true;
        public bool ShowNumbers
        {
            get { return m_ShowNumbers; }
            set { SetProperty(ref m_ShowNumbers, value); }
        }

        bool m_ShowPercents = false;
        public bool ShowPercents
        {
            get { return m_ShowPercents; }
            set { SetProperty(ref m_ShowPercents, value); }
        }

        int m_dPSTimeWindowInSeconds;
        public int DPSTimeWindowInSeconds
        {
            get => m_dPSTimeWindowInSeconds;
            set => SetProperty(ref m_dPSTimeWindowInSeconds, value);
        }

        public TeamWidgetContext()
        {
            Players = new Collection<Player>();
            Fake_Players = new ObservableCollection<Player>();

            UpdateFromConfig();
        }

        public Player UpdateAndGetPlayer(int index, string name, int damage)
        {
            if (String.IsNullOrEmpty(name) && damage == 0)
            {
                if (index < Players.Count)
                {
                    Players.RemoveAt(index);
                    if (DontShowIfAlone && Players.Count() <= 1)
                    {
                        Fake_Players.Clear();
                    }
                    else
                    {
                        Fake_Players.RemoveAt(index);
                    }
                }
                return null;
            }

            while (index >= Players.Count)
            {
                Players.Add(new Player() { Index = Players.Count, Name = LocalizationHelper.GetString(LocalizationHelper.UnknownPlayerStringId) });

                if (DontShowIfAlone && Players.Count() <= 1)
                {
                    Fake_Players.Clear();
                }
                else
                {
                    Fake_Players.Add(Players[Players.Count() - 1]);
                }
            }

            Player player = Players[index];
            if (!String.IsNullOrEmpty(name))
            {
                player.Name = name;
            }
            else if (String.IsNullOrEmpty(player.Name))
            {
                player.Name = LocalizationHelper.GetString(LocalizationHelper.UnknownPlayerStringId);
            }

            // Player doesn't encounter the monster yet
            if (damage == 0)
                return player;

            int damageDifference = damage - player.Damage;
            DateTime now = DateTime.Now;

            if (player.Damage == 0 && damage != 0)
                player.CombatStart = now;
#if DEBUG
            if (damageDifference != 0)
                Log.WriteLine(now + " - " + player.Name + " : current damage = " + damage + " , previous damage = " + player.Damage);
#endif
            if (damageDifference != 0)
                player.DamageHistory.Enqueue((now, damageDifference));

            DateTime historyCutoff = now - TimeSpan.FromSeconds(DPSTimeWindowInSeconds);
            while (player.DamageHistory.Any() && (player.DamageHistory.Peek().Item1 < historyCutoff))
                player.DamageHistory.Dequeue();

            if (player.DamageHistory.Any())
            {
                double historyLengthInSeconds = (now - player.DamageHistory.Peek().Item1).TotalSeconds;
                player.CurrentDPS = player.DamageHistory.Sum(entry => entry.Item2) / (double)historyLengthInSeconds;
            }
            else
                player.CurrentDPS = 0;
#if DEBUG
            if (damageDifference != 0)
                Log.WriteLine(player.Name + " : Total damage = " + damage + ", Total seconds = " + (now - player.CombatStart).TotalSeconds);
#endif
            if ((now - player.CombatStart).TotalSeconds != 0)
                player.DamagePerSecond = damage / (now - player.CombatStart).TotalSeconds;
            else
                player.DamagePerSecond = 999.99;

            if (!OverlayViewModel.Instance.DebugWidget.Context.CurrentGame.IsPlayerInExpedition)
            {
                player.Damage = damage;
            }

            return player;
        }

        public void UpdateFractions()
        {
            var playersWithDamage = Players.Where(player => player.Damage > 0);
            if (!playersWithDamage.Any())
            {
                foreach (var player in Players)
                {
                    player.DamageFraction = 0;
                    player.BarFraction = 0;
                }

                return;
            }

            var highestDamagePlayers = Players.OrderByDescending(player => player.Damage).Take(1);
            if (highestDamagePlayers.Any())
            {
                int totalDamage = Players.Sum(player => player.Damage);

                var highestDamagePlayer = highestDamagePlayers.First();
                highestDamagePlayer.DamageFraction = (float)highestDamagePlayer.Damage / (float)totalDamage;
                highestDamagePlayer.BarFraction = 1;
                //Log.WriteLine(String.Format("{0} {1} {2}", highestDamagePlayer.Damage.ToString(), highestDamagePlayer.DamageFraction.ToString(), highestDamagePlayer.BarFraction.ToString()));
                foreach (var otherPlayer in Players.Except(highestDamagePlayers))
                {
                    otherPlayer.DamageFraction = (float)otherPlayer.Damage / (float)totalDamage;
                    otherPlayer.BarFraction = (float)otherPlayer.Damage / (float)highestDamagePlayer.Damage;
                }
            }
        }

        public void ClearPlayers()
        {
            Players.Clear();
            Fake_Players.Clear();
        }

        public override void UpdateFromConfig()
        {
            base.UpdateFromConfig();

            DontShowIfAlone = ConfigHelper.Main.Values.Overlay.TeamWidget.DontShowIfAlone;
            ShowBars = ConfigHelper.Main.Values.Overlay.TeamWidget.ShowBars;
            ShowNumbers = ConfigHelper.Main.Values.Overlay.TeamWidget.ShowNumbers;
            ShowPercents = ConfigHelper.Main.Values.Overlay.TeamWidget.ShowPercents;
            DPSTimeWindowInSeconds = ConfigHelper.Main.Values.Overlay.TeamWidget.DPSTimeWindowInSeconds;
        }
    }
}
