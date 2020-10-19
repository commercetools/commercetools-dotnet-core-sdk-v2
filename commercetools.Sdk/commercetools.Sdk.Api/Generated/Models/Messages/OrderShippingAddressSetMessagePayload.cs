using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderShippingAddressSet")]
    public partial class OrderShippingAddressSetMessagePayload : MessagePayload
    {
        public Address Address { get; set;}
        
        public Address OldAddress { get; set;}
        public OrderShippingAddressSetMessagePayload()
        { 
           this.Type = "OrderShippingAddressSet";
        }
    }
}
