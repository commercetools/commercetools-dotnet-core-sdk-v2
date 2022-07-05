namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductVariantAvailability : IProductVariantAvailability
    {
        public bool? IsOnStock { get; set; }

        public long? RestockableInDays { get; set; }

        public long? AvailableQuantity { get; set; }

        public IProductVariantChannelAvailabilityMap Channels { get; set; }
    }
}
