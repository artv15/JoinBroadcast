using Exiled.API.Interfaces;
using System.ComponentModel;

namespace JoinBroadcast
{
    public class Config : IConfig
    {
        [Description("Should plugin be enable?")]
        public bool IsEnabled { get; set; }
        [Description("Not used")]
        public bool Debug { get; set; }
        [Description("The text that will be output when connecting to the server.")]
        public string JoinBroadcast { get; set; } = @"<b><color=red>%PlayerName%<color=yellow>, welcome to the ServerName server</color></b>";
        [Description("Duration how long broadcast will be visible")]
        public byte JoinBroadCastDuration { get; set; } = 10;
    }
}
