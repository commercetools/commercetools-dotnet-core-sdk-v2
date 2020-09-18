using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderShippingInfoSet")]
    public class OrderShippingInfoSetMessage : Message
    {
        public ShippingInfo ShippingInfo { get; set;}
        
        public ShippingInfo OldShippingInfo { get; set;}
    }
}
