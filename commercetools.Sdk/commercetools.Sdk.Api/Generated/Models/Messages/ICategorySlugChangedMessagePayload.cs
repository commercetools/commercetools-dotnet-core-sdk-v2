using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.CategorySlugChangedMessagePayload))]
    public partial interface ICategorySlugChangedMessagePayload : IMessagePayload
    {
        ILocalizedString Slug { get; set;}
        
        ILocalizedString OldSlug { get; set;}
    }
}
