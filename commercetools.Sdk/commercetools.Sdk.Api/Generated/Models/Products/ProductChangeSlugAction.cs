using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public  partial class ProductChangeSlugAction : IProductChangeSlugAction
    {
        public string Action { get; set;}
        
        public ILocalizedString Slug { get; set;}
        
        public bool Staged { get; set;}
        public ProductChangeSlugAction()
        { 
           this.Action = "changeSlug";
        }
    }
}
