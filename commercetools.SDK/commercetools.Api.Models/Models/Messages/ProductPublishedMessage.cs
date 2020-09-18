using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("ProductPublished")]
    public class ProductPublishedMessage : Message
    {
        public List<Object> RemovedImageUrls { get; set;}
        
        public ProductProjection ProductProjection { get; set;}
        
        public string Scope { get; set;}
        
        public ProductPublishScope ScopeAsEnum => this.Scope.GetEnum<ProductPublishScope>();
    }
}
