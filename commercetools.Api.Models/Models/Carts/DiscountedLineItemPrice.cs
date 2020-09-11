using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Carts
{
    public class DiscountedLineItemPrice 
    {
        public TypedMoney Value { get; set;}
        
        public List<DiscountedLineItemPortion> IncludedDiscounts { get; set;}
    }
}
