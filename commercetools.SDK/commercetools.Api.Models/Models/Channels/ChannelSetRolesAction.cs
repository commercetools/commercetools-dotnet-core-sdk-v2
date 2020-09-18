using commercetools.Api.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    [DiscriminatorValue("setRoles")]
    public class ChannelSetRolesAction : ChannelUpdateAction
    {
        public List<ChannelRoleEnum> Roles { get; set;}
    }
}
