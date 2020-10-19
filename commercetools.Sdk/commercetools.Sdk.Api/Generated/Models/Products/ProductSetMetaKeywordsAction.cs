using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("setMetaKeywords")]
    public partial class ProductSetMetaKeywordsAction : ProductUpdateAction
    {
        public LocalizedString MetaKeywords { get; set;}
        
        public bool Staged { get; set;}
        public ProductSetMetaKeywordsAction()
        { 
           this.Action = "setMetaKeywords";
        }
    }
}
