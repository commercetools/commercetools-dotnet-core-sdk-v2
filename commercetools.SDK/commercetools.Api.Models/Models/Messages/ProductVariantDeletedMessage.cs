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
    public partial class ProductVariantDeletedMessage : Message
    {
        public ProductVariant Variant { get; set;}
        
        public List<string> RemovedImageUrls { get; set;}
        public ProductVariantDeletedMessage()
        { 
           this.Type = "ProductVariantDeleted";
        }
    }
}
