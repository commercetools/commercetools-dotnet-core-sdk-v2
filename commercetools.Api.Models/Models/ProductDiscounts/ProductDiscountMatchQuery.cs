using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ProductDiscounts
{
    public class ProductDiscountMatchQuery 
    {
        public string ProductId { get; set;}
        
        public int VariantId { get; set;}
        
        public bool Staged { get; set;}
        
        public QueryPrice Price { get; set;}
    }
}
