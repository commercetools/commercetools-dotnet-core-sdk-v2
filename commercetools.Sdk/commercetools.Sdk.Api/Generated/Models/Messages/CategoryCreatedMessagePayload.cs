using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public partial class CategoryCreatedMessagePayload : ICategoryCreatedMessagePayload
    {
        public string Type { get; set;}
        
        public ICategory Category { get; set;}
        public CategoryCreatedMessagePayload()
        { 
           this.Type = "CategoryCreated";
        }
    }
}
