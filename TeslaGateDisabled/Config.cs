using Exiled.API.Interfaces;
using PlayerRoles;
using System.Collections.Generic;
using System.ComponentModel;

namespace TeslaGateDisabled
{
    public class Config : IConfig
    {
        [Description("Is the Plugin enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("Activate debug mode?")]
        public bool Debug { get; set; } = false;

        [Description("Disable all Tesla Gates?")]
        public bool Disable_all { get; set; } = false;

        [Description("Which role can disable TeslaGates?")]
        public List<RoleTypeId> RequiredRole { get; set; } = new List<RoleTypeId>()
        {
            RoleTypeId.NtfPrivate,
            RoleTypeId.NtfSpecialist,
            RoleTypeId.NtfSergeant,
            RoleTypeId.NtfCaptain

        };


    }
}
