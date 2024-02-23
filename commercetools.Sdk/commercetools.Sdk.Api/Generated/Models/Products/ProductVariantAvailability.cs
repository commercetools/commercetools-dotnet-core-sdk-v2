namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductVariantAvailability : IProductVariantAvailability
    {
        public IProductVariantChannelAvailabilityMap Channels { get; set; }

        public bool? IsOnStock { get; set; }

        public long? RestockableInDays { get; set; }

        public long? AvailableQuantity { get; set; }
    }
}
