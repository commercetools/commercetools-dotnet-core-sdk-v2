using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderShippingRateInputSet")]
    public class OrderShippingRateInputSetMessagePayload : MessagePayload
    {
        public ShippingRateInput ShippingRateInput { get; set;}
        
        public ShippingRateInput OldShippingRateInput { get; set;}
    }
}
