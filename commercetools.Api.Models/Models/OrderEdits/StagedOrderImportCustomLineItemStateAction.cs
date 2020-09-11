using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.OrderEdits
{
    public class StagedOrderImportCustomLineItemStateAction : StagedOrderUpdateAction
    {
        public string CustomLineItemId { get; set;}
        
        public List<ItemState> State { get; set;}
    }
}
