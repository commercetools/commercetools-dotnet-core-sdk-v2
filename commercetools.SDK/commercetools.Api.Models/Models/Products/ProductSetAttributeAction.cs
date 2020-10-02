using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("setAttribute")]
    public partial class ProductSetAttributeAction : ProductUpdateAction
    {
        public long VariantId { get; set;}
        
        public string Sku { get; set;}
        
        public string Name { get; set;}
        
        public Object Value { get; set;}
        
        public bool Staged { get; set;}
        public ProductSetAttributeAction()
        { 
           this.Action = "setAttribute";
        }
    }
}
