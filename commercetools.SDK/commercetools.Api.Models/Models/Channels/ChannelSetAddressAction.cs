using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    [DiscriminatorValue("setAddress")]
    public class ChannelSetAddressAction : ChannelUpdateAction
    {
        public Address Address { get; set;}
    }
}
