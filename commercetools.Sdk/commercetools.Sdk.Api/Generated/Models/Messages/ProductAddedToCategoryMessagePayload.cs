using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public partial class ProductAddedToCategoryMessagePayload : IProductAddedToCategoryMessagePayload
    {
        public string Type { get; set;}
        
        public ICategoryReference Category { get; set;}
        
        public bool Staged { get; set;}
        public ProductAddedToCategoryMessagePayload()
        { 
           this.Type = "ProductAddedToCategory";
        }
    }
}
