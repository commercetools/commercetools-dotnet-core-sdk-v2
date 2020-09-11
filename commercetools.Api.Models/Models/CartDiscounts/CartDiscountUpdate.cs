using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.CartDiscounts
{
    public class CartDiscountUpdate 
    {
        public long Version { get; set;}
        
        public List<CartDiscountUpdateAction> Actions { get; set;}
    }
}
