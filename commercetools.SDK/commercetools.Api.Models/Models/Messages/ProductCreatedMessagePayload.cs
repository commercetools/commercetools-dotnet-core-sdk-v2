using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("ProductCreated")]
    public partial class ProductCreatedMessagePayload : MessagePayload
    {
        public ProductProjection ProductProjection { get; set;}
        public ProductCreatedMessagePayload()
        { 
           this.Type = "ProductCreated";
        }
    }
}
