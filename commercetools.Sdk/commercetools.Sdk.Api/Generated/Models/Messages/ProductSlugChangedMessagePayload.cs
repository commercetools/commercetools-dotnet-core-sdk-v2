using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public partial class ProductSlugChangedMessagePayload : IProductSlugChangedMessagePayload
    {
        public string Type { get; set;}
        
        public ILocalizedString Slug { get; set;}
        
        public ILocalizedString OldSlug { get; set;}
        public ProductSlugChangedMessagePayload()
        { 
           this.Type = "ProductSlugChanged";
        }
    }
}
