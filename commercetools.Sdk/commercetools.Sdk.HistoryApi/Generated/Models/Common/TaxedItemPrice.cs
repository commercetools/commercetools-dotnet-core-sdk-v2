namespace commercetools.HistoryApi.Models.Common
{
    public partial class TaxedItemPrice : ITaxedItemPrice
    {
        public IMoney TotalNet { get; set; }

        public IMoney TotalGross { get; set; }
    }
}
