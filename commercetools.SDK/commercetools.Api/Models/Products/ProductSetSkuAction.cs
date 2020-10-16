using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("setSku")]
    public partial class ProductSetSkuAction : ProductUpdateAction
    {
        public long VariantId { get; set;}
        
        public string Sku { get; set;}
        
        public bool Staged { get; set;}
        public ProductSetSkuAction()
        { 
           this.Action = "setSku";
        }
    }
}
