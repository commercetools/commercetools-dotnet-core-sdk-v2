using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("importCustomLineItemState")]
    public class StagedOrderImportCustomLineItemStateAction : StagedOrderUpdateAction
    {
        public string CustomLineItemId { get; set;}
        
        public List<ItemState> State { get; set;}
    }
}
