using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("setImageLabel")]
    public class ProductSetImageLabelAction : ProductUpdateAction
    {
        public string Sku { get; set;}
        
        public long VariantId { get; set;}
        
        public string ImageUrl { get; set;}
        
        public string Label { get; set;}
        
        public bool Staged { get; set;}
    }
}
