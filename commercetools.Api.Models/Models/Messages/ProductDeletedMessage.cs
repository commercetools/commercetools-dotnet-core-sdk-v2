using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class ProductDeletedMessage : Message
    {
        public List<string> RemovedImageUrls { get; set;}
        
        public ProductProjection CurrentProjection { get; set;}
    }
}
