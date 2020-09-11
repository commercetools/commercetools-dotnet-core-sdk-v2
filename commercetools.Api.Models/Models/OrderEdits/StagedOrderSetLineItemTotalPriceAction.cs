using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.OrderEdits
{
    public class StagedOrderSetLineItemTotalPriceAction : StagedOrderUpdateAction
    {
        public string LineItemId { get; set;}
        
        public ExternalLineItemTotalPrice ExternalTotalPrice { get; set;}
    }
}
