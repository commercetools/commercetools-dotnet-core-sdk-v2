using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("setMetaTitle")]
    public class ProductSetMetaTitleAction : ProductUpdateAction
    {
        public LocalizedString MetaTitle { get; set;}
        
        public bool Staged { get; set;}
    }
}
