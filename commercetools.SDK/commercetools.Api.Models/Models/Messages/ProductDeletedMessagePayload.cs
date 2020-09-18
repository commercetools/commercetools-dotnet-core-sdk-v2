using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("ProductDeleted")]
    public class ProductDeletedMessagePayload : MessagePayload
    {
        public List<string> RemovedImageUrls { get; set;}
        
        public ProductProjection CurrentProjection { get; set;}
    }
}
