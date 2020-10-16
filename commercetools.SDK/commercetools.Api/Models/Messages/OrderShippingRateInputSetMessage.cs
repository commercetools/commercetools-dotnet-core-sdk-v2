using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderShippingRateInputSet")]
    public partial class OrderShippingRateInputSetMessage : Message
    {
        public ShippingRateInput ShippingRateInput { get; set;}
        
        public ShippingRateInput OldShippingRateInput { get; set;}
        public OrderShippingRateInputSetMessage()
        { 
           this.Type = "OrderShippingRateInputSet";
        }
    }
}
