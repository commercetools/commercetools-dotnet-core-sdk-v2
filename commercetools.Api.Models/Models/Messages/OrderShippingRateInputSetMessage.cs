using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class OrderShippingRateInputSetMessage : Message
    {
        public ShippingRateInput ShippingRateInput { get; set;}
        
        public ShippingRateInput OldShippingRateInput { get; set;}
    }
}
