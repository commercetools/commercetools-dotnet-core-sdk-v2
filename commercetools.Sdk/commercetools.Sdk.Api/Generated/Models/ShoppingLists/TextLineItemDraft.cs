using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    public partial class TextLineItemDraft : ITextLineItemDraft
    {
        public DateTime? AddedAt { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public ILocalizedString Description { get; set; }

        public ILocalizedString Name { get; set; }

        public int? Quantity { get; set; }
    }
}
