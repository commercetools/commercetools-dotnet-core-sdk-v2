using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public partial class ProductImageAddedMessagePayload : IProductImageAddedMessagePayload
    {
        public string Type { get; set;}
        
        public long VariantId { get; set;}
        
        public IImage Image { get; set;}
        
        public bool Staged { get; set;}
        public ProductImageAddedMessagePayload()
        { 
           this.Type = "ProductImageAdded";
        }
    }
}
