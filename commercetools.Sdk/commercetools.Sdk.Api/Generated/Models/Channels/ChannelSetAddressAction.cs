using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    public partial class ChannelSetAddressAction : IChannelSetAddressAction
    {
        public string Action { get; set;}
        
        public IBaseAddress Address { get; set;}
        public ChannelSetAddressAction()
        { 
           this.Action = "setAddress";
        }
    }
}
