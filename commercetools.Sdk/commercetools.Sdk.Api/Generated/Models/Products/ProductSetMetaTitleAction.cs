using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("setMetaTitle")]
    public partial class ProductSetMetaTitleAction : ProductUpdateAction
    {
        public LocalizedString MetaTitle { get; set;}
        
        public bool Staged { get; set;}
        public ProductSetMetaTitleAction()
        { 
           this.Action = "setMetaTitle";
        }
    }
}
