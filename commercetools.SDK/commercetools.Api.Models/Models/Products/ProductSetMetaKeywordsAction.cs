using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("setMetaKeywords")]
    public class ProductSetMetaKeywordsAction : ProductUpdateAction
    {
        public LocalizedString MetaKeywords { get; set;}
        
        public bool Staged { get; set;}
    }
}
