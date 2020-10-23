using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public  partial class ProductDeletedMessagePayload : IProductDeletedMessagePayload
    {
        public string Type { get; set;}
        
        public List<string> RemovedImageUrls { get; set;}
        
        public IProductProjection CurrentProjection { get; set;}
        public ProductDeletedMessagePayload()
        { 
           this.Type = "ProductDeleted";
        }
    }
}
