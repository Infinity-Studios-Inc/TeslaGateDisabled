using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using MEC;
using PlayerRoles;
using UnityEngine;


namespace TeslaGateDisabled.EventHandler
{
    public class EventHandlers
    {
        private readonly Main main;
        public EventHandlers(Main main) => this.main = main;


        public void OnTriggeringTesla(TriggeringTeslaEventArgs ev)
        {
            bool disabled = Main.Singleton.Config.Disable_all;

            ev.IsAllowed = !disabled;

            if (main.Config.RequiredRole.Contains(ev.Player.Role.Type))
            {
                ev.IsAllowed = false;
            }
        }


    }
}

