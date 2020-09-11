using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Carts
{
    public class DiscountedLineItemPriceForQuantity 
    {
        public double Quantity { get; set;}
        
        public DiscountedLineItemPrice DiscountedPrice { get; set;}
    }
}
