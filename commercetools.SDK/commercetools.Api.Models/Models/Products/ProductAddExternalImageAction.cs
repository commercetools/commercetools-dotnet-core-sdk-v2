using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("addExternalImage")]
    public class ProductAddExternalImageAction : ProductUpdateAction
    {
        public long VariantId { get; set;}
        
        public string Sku { get; set;}
        
        public Image Image { get; set;}
        
        public bool Staged { get; set;}
    }
}
