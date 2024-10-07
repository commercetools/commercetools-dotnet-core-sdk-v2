

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class ProductVariantAvailability : IProductVariantAvailability
    {
        public bool IsOnStock { get; set; }

        public int RestockableInDays { get; set; }

        public int AvailableQuantity { get; set; }

        public IProductVariantChannelAvailabilityMap Channels { get; set; }
    }
}
