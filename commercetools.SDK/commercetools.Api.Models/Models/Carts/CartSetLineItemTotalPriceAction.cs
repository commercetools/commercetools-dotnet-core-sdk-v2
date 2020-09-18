using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setLineItemTotalPrice")]
    public class CartSetLineItemTotalPriceAction : CartUpdateAction
    {
        public string LineItemId { get; set;}
        
        public ExternalLineItemTotalPrice ExternalTotalPrice { get; set;}
    }
}
