using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("CategorySlugChanged")]
    public partial class CategorySlugChangedMessagePayload : MessagePayload
    {
        public LocalizedString Slug { get; set;}
        public CategorySlugChangedMessagePayload()
        { 
           this.Type = "CategorySlugChanged";
        }
    }
}
