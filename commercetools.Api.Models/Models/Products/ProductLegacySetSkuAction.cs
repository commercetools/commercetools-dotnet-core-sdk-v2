using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Products
{
    public class ProductLegacySetSkuAction : ProductUpdateAction
    {
        public string Sku { get; set;}
        
        public int VariantId { get; set;}
    }
}
