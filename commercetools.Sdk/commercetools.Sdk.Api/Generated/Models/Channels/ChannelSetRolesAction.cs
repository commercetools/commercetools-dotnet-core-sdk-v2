using commercetools.Sdk.Api.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Channels
{

    public partial class ChannelSetRolesAction : IChannelSetRolesAction
    {
        public string Action { get; set; }

        public IList<IChannelRoleEnum> Roles { get; set; }
        public IEnumerable<IChannelRoleEnum> RolesEnumerable { set => Roles = value.ToList(); }

        public ChannelSetRolesAction()
        {
            this.Action = "setRoles";
        }
    }
}
