using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("CategoryCreated")]
    public partial class CategoryCreatedMessagePayload : MessagePayload
    {
        public Category Category { get; set;}
        public CategoryCreatedMessagePayload()
        { 
           this.Type = "CategoryCreated";
        }
    }
}
