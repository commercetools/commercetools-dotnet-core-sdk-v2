using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Products
{
    public class ProductSetSearchKeywordsAction : ProductUpdateAction
    {
        public SearchKeywords SearchKeywords { get; set;}
        
        public bool Staged { get; set;}
    }
}
