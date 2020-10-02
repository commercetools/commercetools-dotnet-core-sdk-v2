using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    [DiscriminatorValue("setAddress")]
    public partial class ChannelSetAddressAction : ChannelUpdateAction
    {
        public Address Address { get; set;}
        public ChannelSetAddressAction()
        { 
           this.Action = "setAddress";
        }
    }
}
