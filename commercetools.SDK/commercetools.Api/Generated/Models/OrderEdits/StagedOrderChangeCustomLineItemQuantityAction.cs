using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("changeCustomLineItemQuantity")]
    public partial class StagedOrderChangeCustomLineItemQuantityAction : StagedOrderUpdateAction
    {
        public string CustomLineItemId { get; set;}
        
        public double Quantity { get; set;}
        public StagedOrderChangeCustomLineItemQuantityAction()
        { 
           this.Action = "changeCustomLineItemQuantity";
        }
    }
}
