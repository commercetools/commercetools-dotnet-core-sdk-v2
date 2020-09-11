using commercetools.Api.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Channels
{
    public class ChannelRemoveRolesAction : ChannelUpdateAction
    {
        public List<ChannelRoleEnum> Roles { get; set;}
    }
}
