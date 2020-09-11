using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.OrderEdits
{
    public class StagedOrderChangeCustomLineItemQuantityAction : StagedOrderUpdateAction
    {
        public string CustomLineItemId { get; set;}
        
        public double Quantity { get; set;}
    }
}
