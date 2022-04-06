namespace commercetools.Sdk.HistoryApi.Models.Common
{
    public partial class LineItem : ILineItem
    {
        public string AddedAt { get; set; }

        public ICustomFields Custom { get; set; }

        public string Id { get; set; }

        public ILocalizedString Name { get; set; }

        public string ProductId { get; set; }

        public ILocalizedString ProductSlug { get; set; }

        public IReference ProductType { get; set; }

        public int Quantity { get; set; }

        public IVariant Variant { get; set; }

        public int VariantId { get; set; }
    }
}
