using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("setAttribute")]
    public class ProductSetAttributeAction : ProductUpdateAction
    {
        public long VariantId { get; set;}
        
        public string Sku { get; set;}
        
        public string Name { get; set;}
        
        public Object Value { get; set;}
        
        public bool Staged { get; set;}
    }
}
