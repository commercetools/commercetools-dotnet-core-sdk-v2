using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("legacySetSku")]
    public partial class ProductLegacySetSkuAction : ProductUpdateAction
    {
        public string Sku { get; set;}
        
        public int VariantId { get; set;}
        public ProductLegacySetSkuAction()
        { 
           this.Action = "legacySetSku";
        }
    }
}
