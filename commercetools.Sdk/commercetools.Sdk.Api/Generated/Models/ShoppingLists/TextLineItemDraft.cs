using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;


namespace commercetools.Api.Models.ShoppingLists
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
