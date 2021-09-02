using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.CategorySlugChangedMessage))]
    public partial interface ICategorySlugChangedMessage : IMessage
    {
        ILocalizedString Slug { get; set; }

        ILocalizedString OldSlug { get; set; }
    }
}
