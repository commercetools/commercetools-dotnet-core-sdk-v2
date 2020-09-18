using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setLineItemShippingDetails")]
    public class CartSetLineItemShippingDetailsAction : CartUpdateAction
    {
        public string LineItemId { get; set;}
        
        public ItemShippingDetailsDraft ShippingDetails { get; set;}
    }
}
