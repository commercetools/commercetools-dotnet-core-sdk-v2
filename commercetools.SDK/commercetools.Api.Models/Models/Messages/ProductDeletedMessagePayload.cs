using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("ProductDeleted")]
    public partial class ProductDeletedMessagePayload : MessagePayload
    {
        public List<string> RemovedImageUrls { get; set;}
        
        public ProductProjection CurrentProjection { get; set;}
        public ProductDeletedMessagePayload()
        { 
           this.Type = "ProductDeleted";
        }
    }
}
