using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("changeCustomLineItemQuantity")]
    public class CartChangeCustomLineItemQuantityAction : CartUpdateAction
    {
        public string CustomLineItemId { get; set;}
        
        public double Quantity { get; set;}
    }
}
