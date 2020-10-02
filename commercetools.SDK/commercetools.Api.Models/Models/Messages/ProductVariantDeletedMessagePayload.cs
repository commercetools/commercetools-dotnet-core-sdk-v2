using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("ProductVariantDeleted")]
    public partial class ProductVariantDeletedMessagePayload : MessagePayload
    {
        public ProductVariant Variant { get; set;}
        
        public List<string> RemovedImageUrls { get; set;}
        public ProductVariantDeletedMessagePayload()
        { 
           this.Type = "ProductVariantDeleted";
        }
    }
}
