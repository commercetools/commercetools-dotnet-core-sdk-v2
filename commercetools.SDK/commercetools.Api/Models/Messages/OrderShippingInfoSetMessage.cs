using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderShippingInfoSet")]
    public partial class OrderShippingInfoSetMessage : Message
    {
        public ShippingInfo ShippingInfo { get; set;}
        
        public ShippingInfo OldShippingInfo { get; set;}
        public OrderShippingInfoSetMessage()
        { 
           this.Type = "OrderShippingInfoSet";
        }
    }
}
