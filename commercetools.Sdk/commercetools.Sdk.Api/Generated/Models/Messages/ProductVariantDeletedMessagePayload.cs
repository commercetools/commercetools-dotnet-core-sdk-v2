using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public partial class ProductVariantDeletedMessagePayload : IProductVariantDeletedMessagePayload
    {
        public string Type { get; set;}
        
        public IProductVariant Variant { get; set;}
        
        public List<string> RemovedImageUrls { get; set;}
        public ProductVariantDeletedMessagePayload()
        { 
           this.Type = "ProductVariantDeleted";
        }
    }
}
