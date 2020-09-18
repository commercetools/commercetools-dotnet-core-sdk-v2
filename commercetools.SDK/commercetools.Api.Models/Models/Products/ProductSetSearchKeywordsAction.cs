using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("setSearchKeywords")]
    public class ProductSetSearchKeywordsAction : ProductUpdateAction
    {
        public SearchKeywords SearchKeywords { get; set;}
        
        public bool Staged { get; set;}
    }
}
