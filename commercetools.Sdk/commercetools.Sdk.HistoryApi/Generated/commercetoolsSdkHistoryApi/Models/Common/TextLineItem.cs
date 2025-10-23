using System;

namespace commercetools.Sdk.HistoryApi.Models.Common
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
