using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("importLineItemState")]
    public class OrderImportLineItemStateAction : OrderUpdateAction
    {
        public string LineItemId { get; set;}
        
        public List<ItemState> State { get; set;}
    }
}
