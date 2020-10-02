using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderShippingInfoSet")]
    public partial class OrderShippingInfoSetMessagePayload : MessagePayload
    {
        public ShippingInfo ShippingInfo { get; set;}
        
        public ShippingInfo OldShippingInfo { get; set;}
        public OrderShippingInfoSetMessagePayload()
        { 
           this.Type = "OrderShippingInfoSet";
        }
    }
}
