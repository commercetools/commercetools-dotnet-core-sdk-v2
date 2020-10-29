using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public partial class ProductSetProductPriceCustomFieldAction : IProductSetProductPriceCustomFieldAction
    {
        public string Action { get; set;}
        
        public string PriceId { get; set;}
        
        public bool? Staged { get; set;}
        
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public ProductSetProductPriceCustomFieldAction()
        { 
           this.Action = "setProductPriceCustomField";
        }
    }
}
