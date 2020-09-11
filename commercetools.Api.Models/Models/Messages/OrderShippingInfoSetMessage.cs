using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class OrderShippingInfoSetMessage : Message
    {
        public ShippingInfo ShippingInfo { get; set;}
        
        public ShippingInfo OldShippingInfo { get; set;}
    }
}
