using commercetools.Api.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    [DiscriminatorValue("setCustomField")]
    public class ChannelSetCustomFieldAction : ChannelUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
    }
}
