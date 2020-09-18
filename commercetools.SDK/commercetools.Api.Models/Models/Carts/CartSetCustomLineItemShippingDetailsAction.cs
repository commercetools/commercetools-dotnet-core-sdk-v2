using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setCustomLineItemShippingDetails")]
    public class CartSetCustomLineItemShippingDetailsAction : CartUpdateAction
    {
        public string CustomLineItemId { get; set;}
        
        public ItemShippingDetailsDraft ShippingDetails { get; set;}
    }
}
