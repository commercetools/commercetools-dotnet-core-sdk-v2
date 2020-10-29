using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public partial class CategorySlugChangedMessagePayload : ICategorySlugChangedMessagePayload
    {
        public string Type { get; set;}
        
        public ILocalizedString Slug { get; set;}
        public CategorySlugChangedMessagePayload()
        { 
           this.Type = "CategorySlugChanged";
        }
    }
}
