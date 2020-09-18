using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("CustomerAddressChanged")]
    public class CustomerAddressChangedMessagePayload : MessagePayload
    {
        public Address Address { get; set;}
    }
}
