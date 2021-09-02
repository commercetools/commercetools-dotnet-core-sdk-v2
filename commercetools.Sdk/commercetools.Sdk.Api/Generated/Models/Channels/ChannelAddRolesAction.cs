using commercetools.Api.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    public partial class ChannelAddRolesAction : IChannelAddRolesAction
    {
        public string Action { get; set; }

        public List<IChannelRoleEnum> Roles { get; set; }
        public ChannelAddRolesAction()
        {
            this.Action = "addRoles";
        }
    }
}
