using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("changeOrderState")]
    public partial class OrderChangeOrderStateAction : OrderUpdateAction
    {
        public string OrderState { get; set;}
        
        [JsonIgnore]
        public OrderState OrderStateAsEnum => this.OrderState.GetEnum<OrderState>();
        public OrderChangeOrderStateAction()
        { 
           this.Action = "changeOrderState";
        }
    }
}
