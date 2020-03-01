using System.Collections.Generic;
using SmartHunter.Core.Data;

namespace SmartHunter.Game.Data.WidgetContexts
{
    public class DebugWidgetContext : WidgetContext
    {
        public Game CurrentGame { get; set; }
        
        public void UpdateCurrentGame(string playerName, string weaponString, string sessionID, string sessionHostName, string lobbyID, string lobbyHostName, List<Player> sessionPlayers)
        {
            CurrentGame.CurrentPlayerName = playerName;
            CurrentGame.CurrentWeaponString = weaponString;
            CurrentGame.SessionID = sessionID;
            CurrentGame.SessionHostPlayerName = sessionHostName;
            CurrentGame.SessionPlayers = sessionPlayers;
            CurrentGame.LobbyID = lobbyID;
            CurrentGame.LobbyHostPlayerName = lobbyHostName;
            CurrentGame.IsValid = true;
        }
        public DebugWidgetContext()
        {
            CurrentGame = new Game();
        }

        public override void UpdateFromConfig()
        {
            base.UpdateFromConfig();
        }
    }
}
