using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public class DiscountedLineItemPriceForQuantity 
    {
        public double Quantity { get; set;}
        
        public DiscountedLineItemPrice DiscountedPrice { get; set;}
    }
}
