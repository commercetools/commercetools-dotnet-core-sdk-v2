using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("removeVariant")]
    public class ProductRemoveVariantAction : ProductUpdateAction
    {
        public long Id { get; set;}
        
        public string Sku { get; set;}
        
        public bool Staged { get; set;}
    }
}
