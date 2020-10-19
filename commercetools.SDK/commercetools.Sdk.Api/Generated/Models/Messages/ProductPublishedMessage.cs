using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("ProductPublished")]
    public partial class ProductPublishedMessage : Message
    {
        public List<Object> RemovedImageUrls { get; set;}
        
        public ProductProjection ProductProjection { get; set;}
        
        public string Scope { get; set;}
        
        [JsonIgnore]
        public ProductPublishScope ScopeAsEnum => this.Scope.GetEnum<ProductPublishScope>();
        public ProductPublishedMessage()
        { 
           this.Type = "ProductPublished";
        }
    }
}
