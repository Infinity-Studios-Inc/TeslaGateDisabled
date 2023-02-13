using Exiled.API.Enums;
using Exiled.API.Features;
using System;
using EventHandlers = Exiled.Events.Handlers.Player;

namespace TeslaGateDisabled
{
    public class Main : Plugin<Config>
    {
        public static readonly Main Singleton = new Main();

        public override string Author { get; } = "Inzi";
        public override string Name { get; } = "TeslaGateDisabled";
        public override string Prefix { get; } = "TeslaGateDisabled";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(6, 0, 0);

        public override PluginPriority Priority { get; } = PluginPriority.High;


        private EventHandler.EventHandlers eventhandler;

        private Main()
        {

        }

        public static Main Instance
        {
            get => Singleton;
        }

        public override void OnEnabled()
        {
            RegisterEvents();
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            UnregisterEvents();
            base.OnDisabled();
        }

        public void RegisterEvents()
        {
            eventhandler = new EventHandler.EventHandlers(this);

            EventHandlers.TriggeringTesla += eventhandler.OnTriggeringTesla;
        }

        public void UnregisterEvents()
        { 
            EventHandlers.TriggeringTesla += eventhandler.OnTriggeringTesla;

            eventhandler = null;
        }

        public override void OnReloaded()
        {
            base.OnReloaded();
        }

    }
}
