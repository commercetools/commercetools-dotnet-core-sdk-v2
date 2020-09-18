using commercetools.Api.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    [DiscriminatorValue("addRoles")]
    public class ChannelAddRolesAction : ChannelUpdateAction
    {
        public List<ChannelRoleEnum> Roles { get; set;}
    }
}
