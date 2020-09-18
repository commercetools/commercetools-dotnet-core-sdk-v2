using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("changeOrderState")]
    public class OrderChangeOrderStateAction : OrderUpdateAction
    {
        public string OrderState { get; set;}
        
        public OrderState OrderStateAsEnum => this.OrderState.GetEnum<OrderState>();
    }
}
