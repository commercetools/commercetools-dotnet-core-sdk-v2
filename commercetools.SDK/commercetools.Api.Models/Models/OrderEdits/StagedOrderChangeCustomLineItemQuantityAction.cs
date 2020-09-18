using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("changeCustomLineItemQuantity")]
    public class StagedOrderChangeCustomLineItemQuantityAction : StagedOrderUpdateAction
    {
        public string CustomLineItemId { get; set;}
        
        public double Quantity { get; set;}
    }
}
