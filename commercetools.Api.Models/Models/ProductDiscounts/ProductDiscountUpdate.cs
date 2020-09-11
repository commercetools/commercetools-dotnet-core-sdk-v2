using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ProductDiscounts
{
    public class ProductDiscountUpdate 
    {
        public long Version { get; set;}
        
        public List<ProductDiscountUpdateAction> Actions { get; set;}
    }
}
