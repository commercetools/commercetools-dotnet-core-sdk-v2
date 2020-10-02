using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("CustomerAddressChanged")]
    public partial class CustomerAddressChangedMessagePayload : MessagePayload
    {
        public Address Address { get; set;}
        public CustomerAddressChangedMessagePayload()
        { 
           this.Type = "CustomerAddressChanged";
        }
    }
}
