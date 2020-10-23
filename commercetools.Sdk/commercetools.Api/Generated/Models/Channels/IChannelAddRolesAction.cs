using commercetools.Api.Generated.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Channels
{
    public interface IChannelAddRolesAction : IChannelUpdateAction
    {
        List<string> Roles { get; set;}
        
        List<ChannelRoleEnum> RolesAsEnum { get; }
    }
}
