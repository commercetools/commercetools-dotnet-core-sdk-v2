using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderShippingAddressSet")]
    public partial class OrderShippingAddressSetMessage : Message
    {
        public Address Address { get; set;}
        
        public Address OldAddress { get; set;}
        public OrderShippingAddressSetMessage()
        { 
           this.Type = "OrderShippingAddressSet";
        }
    }
}
