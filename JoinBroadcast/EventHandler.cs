using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinBroadcast
{
    public class EventHandler
    {
        Config _config = JoinBroadcast.Singleton.Config;

        public void OnJoining(VerifiedEventArgs ev) =>
            ev.Player.Broadcast(_config.JoinBroadCastDuration, _config.JoinBroadcast.Replace("%PlayerName%", ev.Player.Nickname)); //make it one-line
    }
}
