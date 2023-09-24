using System;
using Exiled.API.Features;
using Exiled.Loader.Features;

namespace JoinBroadcast
{
    public class JoinBroadcast : Plugin<Config>
    {
        private EventHandler EventHandler;
        public static JoinBroadcast Singleton;
        Config _config;

        public override string Name => "test";
        public override string Author => "MotVARD";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(8, 2, 1);

        public override void OnEnabled()
        {
            Singleton = this;
            EventHandler = new EventHandler();
            _config = Config;

            Exiled.Events.Handlers.Player.Verified += EventHandler.OnJoining;

            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Verified -= EventHandler.OnJoining;

            EventHandler = null;
            _config = null;
            Singleton = null;

            base.OnDisabled();

        }
    }
}
