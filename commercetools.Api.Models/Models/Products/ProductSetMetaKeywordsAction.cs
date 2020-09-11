using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Products
{
    public class ProductSetMetaKeywordsAction : ProductUpdateAction
    {
        public LocalizedString MetaKeywords { get; set;}
        
        public bool Staged { get; set;}
    }
}
