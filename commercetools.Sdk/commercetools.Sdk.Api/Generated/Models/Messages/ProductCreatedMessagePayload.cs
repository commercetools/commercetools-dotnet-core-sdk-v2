using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public partial class ProductCreatedMessagePayload : IProductCreatedMessagePayload
    {
        public string Type { get; set;}
        
        public IProductProjection ProductProjection { get; set;}
        public ProductCreatedMessagePayload()
        { 
           this.Type = "ProductCreated";
        }
    }
}
