using commercetools.Api.Models.Categorys;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("ProductRemovedFromCategory")]
    public partial class ProductRemovedFromCategoryMessage : Message
    {
        public CategoryReference Category { get; set;}
        
        public bool Staged { get; set;}
        public ProductRemovedFromCategoryMessage()
        { 
           this.Type = "ProductRemovedFromCategory";
        }
    }
}
