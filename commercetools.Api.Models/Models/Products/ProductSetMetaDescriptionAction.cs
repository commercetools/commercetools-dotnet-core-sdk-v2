using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Products
{
    public class ProductSetMetaDescriptionAction : ProductUpdateAction
    {
        public LocalizedString MetaDescription { get; set;}
        
        public bool Staged { get; set;}
    }
}
