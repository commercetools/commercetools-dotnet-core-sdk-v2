using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("CustomerAddressAdded")]
    public partial class CustomerAddressAddedMessagePayload : MessagePayload
    {
        public Address Address { get; set;}
        public CustomerAddressAddedMessagePayload()
        { 
           this.Type = "CustomerAddressAdded";
        }
    }
}
