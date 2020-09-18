using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderStateChanged")]
    public class OrderStateChangedMessage : Message
    {
        public string OrderState { get; set;}
        
        public OrderState OrderStateAsEnum => this.OrderState.GetEnum<OrderState>();
        
        public string OldOrderState { get; set;}
        
        public OrderState OldOrderStateAsEnum => this.OldOrderState.GetEnum<OrderState>();
    }
}
