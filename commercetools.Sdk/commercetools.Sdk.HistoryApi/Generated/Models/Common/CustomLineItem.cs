namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class CustomLineItem : ICustomLineItem
    {
        public string Id { get; set; }

        public ILocalizedString Name { get; set; }

        public IMoney Money { get; set; }

        public ITaxedItemPrice TaxedPrice { get; set; }

        public IMoney TotalPrice { get; set; }

        public string Slug { get; set; }

        public int Quantity { get; set; }
    }
}
