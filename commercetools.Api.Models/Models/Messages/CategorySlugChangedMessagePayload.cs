using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class CategorySlugChangedMessagePayload : MessagePayload
    {
        public LocalizedString Slug { get; set;}
    }
}
