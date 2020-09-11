using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class ProductCreatedMessagePayload : MessagePayload
    {
        public ProductProjection ProductProjection { get; set;}
    }
}
