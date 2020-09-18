using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("legacySetSku")]
    public class ProductLegacySetSkuAction : ProductUpdateAction
    {
        public string Sku { get; set;}
        
        public int VariantId { get; set;}
    }
}
