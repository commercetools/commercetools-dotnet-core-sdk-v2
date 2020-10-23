using commercetools.Api.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    [DeserializeAs(typeof(commercetools.Api.Models.Channels.ChannelRemoveRolesAction))]
    public interface IChannelRemoveRolesAction : IChannelUpdateAction
    {
        List<string> Roles { get; set;}
        
        List<ChannelRoleEnum> RolesAsEnum { get; }
    }
}
