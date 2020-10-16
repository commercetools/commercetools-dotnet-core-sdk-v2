using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("ProductRemovedFromCategory")]
    public partial class ProductRemovedFromCategoryMessagePayload : MessagePayload
    {
        public CategoryReference Category { get; set;}
        
        public bool Staged { get; set;}
        public ProductRemovedFromCategoryMessagePayload()
        { 
           this.Type = "ProductRemovedFromCategory";
        }
    }
}
