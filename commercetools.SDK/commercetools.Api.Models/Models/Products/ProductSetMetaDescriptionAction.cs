using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("setMetaDescription")]
    public partial class ProductSetMetaDescriptionAction : ProductUpdateAction
    {
        public LocalizedString MetaDescription { get; set;}
        
        public bool Staged { get; set;}
        public ProductSetMetaDescriptionAction()
        { 
           this.Action = "setMetaDescription";
        }
    }
}
