using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Common
{
    public class DiscountedPrice 
    {
        public Money Value { get; set;}
        
        public ProductDiscountReference Discount { get; set;}
    }
}
