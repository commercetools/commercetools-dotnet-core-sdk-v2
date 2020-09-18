using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setLineItemShippingDetails")]
    public class MyCartSetLineItemShippingDetailsAction : MyCartUpdateAction
    {
        public string LineItemId { get; set;}
        
        public ItemShippingDetailsDraft ShippingDetails { get; set;}
    }
}
