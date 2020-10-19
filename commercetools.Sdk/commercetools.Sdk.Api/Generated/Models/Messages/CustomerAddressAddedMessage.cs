using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("CustomerAddressAdded")]
    public partial class CustomerAddressAddedMessage : Message
    {
        public Address Address { get; set;}
        public CustomerAddressAddedMessage()
        { 
           this.Type = "CustomerAddressAdded";
        }
    }
}
