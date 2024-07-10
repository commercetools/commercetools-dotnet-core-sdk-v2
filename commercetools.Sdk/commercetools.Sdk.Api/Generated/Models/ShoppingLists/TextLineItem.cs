using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{

    public partial class TextLineItem : ITextLineItem
    {
        public DateTime AddedAt { get; set; }

        public ICustomFields Custom { get; set; }

        public ILocalizedString Description { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }

        public ILocalizedString Name { get; set; }

        public long Quantity { get; set; }
    }
}
