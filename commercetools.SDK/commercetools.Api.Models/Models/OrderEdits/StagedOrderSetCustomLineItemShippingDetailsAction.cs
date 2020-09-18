using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setCustomLineItemShippingDetails")]
    public class StagedOrderSetCustomLineItemShippingDetailsAction : StagedOrderUpdateAction
    {
        public string CustomLineItemId { get; set;}
        
        public ItemShippingDetailsDraft ShippingDetails { get; set;}
    }
}
