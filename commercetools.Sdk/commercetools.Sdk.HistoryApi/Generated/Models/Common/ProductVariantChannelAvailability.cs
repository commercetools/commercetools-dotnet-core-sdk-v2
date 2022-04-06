namespace commercetools.Sdk.HistoryApi.Models.Common
{
    public partial class ProductVariantChannelAvailability : IProductVariantChannelAvailability
    {
        public bool IsOnStock { get; set; }

        public int RestockableInDays { get; set; }

        public int AvailableQuantity { get; set; }
    }
}
