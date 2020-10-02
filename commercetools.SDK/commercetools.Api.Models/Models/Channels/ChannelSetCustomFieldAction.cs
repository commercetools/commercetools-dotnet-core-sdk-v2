using commercetools.Api.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    [DiscriminatorValue("setCustomField")]
    public partial class ChannelSetCustomFieldAction : ChannelUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public ChannelSetCustomFieldAction()
        { 
           this.Action = "setCustomField";
        }
    }
}
