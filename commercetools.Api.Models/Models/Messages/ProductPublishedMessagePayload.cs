using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class ProductPublishedMessagePayload : MessagePayload
    {
        public List<Object> RemovedImageUrls { get; set;}
        
        public ProductProjection ProductProjection { get; set;}
        
        public ProductPublishScope Scope { get; set;}
    }
}
