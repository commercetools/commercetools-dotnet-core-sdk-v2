using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("importCustomLineItemState")]
    public class OrderImportCustomLineItemStateAction : OrderUpdateAction
    {
        public string CustomLineItemId { get; set;}
        
        public List<ItemState> State { get; set;}
    }
}
