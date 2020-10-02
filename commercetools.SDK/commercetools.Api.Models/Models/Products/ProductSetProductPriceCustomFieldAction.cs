using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("setProductPriceCustomField")]
    public partial class ProductSetProductPriceCustomFieldAction : ProductUpdateAction
    {
        public string PriceId { get; set;}
        
        public bool Staged { get; set;}
        
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public ProductSetProductPriceCustomFieldAction()
        { 
           this.Action = "setProductPriceCustomField";
        }
    }
}
