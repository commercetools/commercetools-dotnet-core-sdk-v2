using commercetools.Api.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    public partial class ChannelSetAddressCustomFieldAction : IChannelSetAddressCustomFieldAction
    {
        public string Action { get; set;}
        
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public ChannelSetAddressCustomFieldAction()
        { 
           this.Action = "setAddressCustomField";
        }
    }
}
