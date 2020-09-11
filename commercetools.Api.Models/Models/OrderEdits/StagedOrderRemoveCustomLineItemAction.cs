using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.OrderEdits
{
    public class StagedOrderRemoveCustomLineItemAction : StagedOrderUpdateAction
    {
        public string CustomLineItemId { get; set;}
    }
}
