using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("ProductVariantDeleted")]
    public class ProductVariantDeletedMessagePayload : MessagePayload
    {
        public ProductVariant Variant { get; set;}
        
        public List<string> RemovedImageUrls { get; set;}
    }
}
