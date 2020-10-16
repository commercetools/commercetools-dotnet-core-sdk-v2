using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("CategorySlugChanged")]
    public partial class CategorySlugChangedMessage : Message
    {
        public LocalizedString Slug { get; set;}
        public CategorySlugChangedMessage()
        { 
           this.Type = "CategorySlugChanged";
        }
    }
}
