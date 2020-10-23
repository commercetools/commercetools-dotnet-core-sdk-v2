using commercetools.Api.Generated.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Channels
{
    public interface IChannelSetCustomFieldAction : IChannelUpdateAction
    {
        string Name { get; set;}
        
        Object Value { get; set;}
    }
}
