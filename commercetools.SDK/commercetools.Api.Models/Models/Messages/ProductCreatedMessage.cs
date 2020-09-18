using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("ProductCreated")]
    public class ProductCreatedMessage : Message
    {
        public ProductProjection ProductProjection { get; set;}
    }
}
