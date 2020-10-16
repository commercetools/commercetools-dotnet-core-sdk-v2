using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("ProductSlugChanged")]
    public partial class ProductSlugChangedMessagePayload : MessagePayload
    {
        public LocalizedString Slug { get; set;}
        public ProductSlugChangedMessagePayload()
        { 
           this.Type = "ProductSlugChanged";
        }
    }
}
