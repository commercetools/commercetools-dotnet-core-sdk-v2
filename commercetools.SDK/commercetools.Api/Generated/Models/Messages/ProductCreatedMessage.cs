using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("ProductCreated")]
    public partial class ProductCreatedMessage : Message
    {
        public ProductProjection ProductProjection { get; set;}
        public ProductCreatedMessage()
        { 
           this.Type = "ProductCreated";
        }
    }
}
