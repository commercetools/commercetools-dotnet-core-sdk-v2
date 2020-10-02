using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderShippingRateInputSet")]
    public partial class OrderShippingRateInputSetMessagePayload : MessagePayload
    {
        public ShippingRateInput ShippingRateInput { get; set;}
        
        public ShippingRateInput OldShippingRateInput { get; set;}
        public OrderShippingRateInputSetMessagePayload()
        { 
           this.Type = "OrderShippingRateInputSet";
        }
    }
}
