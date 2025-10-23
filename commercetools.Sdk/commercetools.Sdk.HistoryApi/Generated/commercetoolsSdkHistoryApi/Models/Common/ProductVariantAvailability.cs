

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class ProductVariantAvailability : IProductVariantAvailability
    {
        public IProductVariantChannelAvailabilityMap Channels { get; set; }

        public bool? IsOnStock { get; set; }

        public long? RestockableInDays { get; set; }

        public long? AvailableQuantity { get; set; }

        public string Id { get; set; }

        public long? Version { get; set; }
    }
}
