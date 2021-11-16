using commercetools.Api.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    [DeserializeAs(typeof(commercetools.Api.Models.Channels.ChannelSetAddressCustomFieldAction))]
    public partial interface IChannelSetAddressCustomFieldAction : IChannelUpdateAction
    {
        string Name { get; set;}
        
        Object Value { get; set;}
    }
}
