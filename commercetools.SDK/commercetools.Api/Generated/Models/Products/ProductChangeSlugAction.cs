using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("changeSlug")]
    public partial class ProductChangeSlugAction : ProductUpdateAction
    {
        public LocalizedString Slug { get; set;}
        
        public bool Staged { get; set;}
        public ProductChangeSlugAction()
        { 
           this.Action = "changeSlug";
        }
    }
}
