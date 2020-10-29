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
    public partial class ProductPublishedMessagePayload : IProductPublishedMessagePayload
    {
        public string Type { get; set;}
        
        public List<Object> RemovedImageUrls { get; set;}
        
        public IProductProjection ProductProjection { get; set;}
        
        public string Scope { get; set;}
        
        [JsonIgnore]
        public ProductPublishScope ScopeAsEnum => this.Scope.GetEnum<ProductPublishScope>();
        public ProductPublishedMessagePayload()
        { 
           this.Type = "ProductPublished";
        }
    }
}
