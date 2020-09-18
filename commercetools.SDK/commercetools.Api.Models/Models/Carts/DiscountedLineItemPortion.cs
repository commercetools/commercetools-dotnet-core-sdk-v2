using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public class DiscountedLineItemPortion 
    {
        public CartDiscountReference Discount { get; set;}
        
        public TypedMoney DiscountedAmount { get; set;}
    }
}
