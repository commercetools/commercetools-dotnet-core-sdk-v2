using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("changeSlug")]
    public class ProductChangeSlugAction : ProductUpdateAction
    {
        public LocalizedString Slug { get; set;}
        
        public bool Staged { get; set;}
    }
}
