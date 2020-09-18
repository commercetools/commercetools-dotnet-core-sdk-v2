using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("importLineItemState")]
    public class StagedOrderImportLineItemStateAction : StagedOrderUpdateAction
    {
        public string LineItemId { get; set;}
        
        public List<ItemState> State { get; set;}
    }
}
