

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class ProductVariantChannelAvailability : IProductVariantChannelAvailability
    {
        public bool? IsOnStock { get; set; }

        public long? RestockableInDays { get; set; }

        public long? AvailableQuantity { get; set; }

        public string Id { get; set; }

        public long Version { get; set; }
    }
}
