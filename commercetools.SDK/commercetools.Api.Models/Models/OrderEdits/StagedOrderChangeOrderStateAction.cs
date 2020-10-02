using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("changeOrderState")]
    public partial class StagedOrderChangeOrderStateAction : StagedOrderUpdateAction
    {
        public string OrderState { get; set;}
        
        [JsonIgnore]
        public OrderState OrderStateAsEnum => this.OrderState.GetEnum<OrderState>();
        public StagedOrderChangeOrderStateAction()
        { 
           this.Action = "changeOrderState";
        }
    }
}
