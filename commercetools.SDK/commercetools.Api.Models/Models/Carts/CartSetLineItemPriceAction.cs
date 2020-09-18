using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setLineItemPrice")]
    public class CartSetLineItemPriceAction : CartUpdateAction
    {
        public string LineItemId { get; set;}
        
        public Money ExternalPrice { get; set;}
    }
}
