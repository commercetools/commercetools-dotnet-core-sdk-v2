using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class ProductVariantDeletedMessage : Message
    {
        public ProductVariant Variant { get; set;}
        
        public List<string> RemovedImageUrls { get; set;}
    }
}
