namespace commercetools.HistoryApi.Models.Common
{
    public partial class TextLineItem : ITextLineItem
    {
        public string AddedAt { get; set; }

        public ICustomFields Custom { get; set; }

        public ILocalizedString Description { get; set; }

        public string Id { get; set; }

        public ILocalizedString Name { get; set; }

        public int Quantity { get; set; }
    }
}
