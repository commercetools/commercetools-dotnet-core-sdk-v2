using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Orders
{
    public class DiscountedLineItemPriceDraft 
    {
        public Money Value { get; set;}
        
        public List<DiscountedLineItemPortion> IncludedDiscounts { get; set;}
    }
}
