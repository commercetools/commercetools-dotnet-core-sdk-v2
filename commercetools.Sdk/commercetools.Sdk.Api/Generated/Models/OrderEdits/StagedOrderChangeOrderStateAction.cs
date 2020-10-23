using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public  partial class StagedOrderChangeOrderStateAction : IStagedOrderChangeOrderStateAction
    {
        public string Action { get; set;}
        
        public string OrderState { get; set;}
        
        [JsonIgnore]
        public OrderState OrderStateAsEnum => this.OrderState.GetEnum<OrderState>();
        public StagedOrderChangeOrderStateAction()
        { 
           this.Action = "changeOrderState";
        }
    }
}
