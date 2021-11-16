using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;


namespace commercetools.Api.Models.ShoppingLists
{
    public partial class TextLineItem : ITextLineItem
    {
        public DateTime AddedAt { get; set; }

        public ICustomFields Custom { get; set; }

        public ILocalizedString Description { get; set; }

        public string Id { get; set; }

        public ILocalizedString Name { get; set; }

        public int Quantity { get; set; }
    }
}
