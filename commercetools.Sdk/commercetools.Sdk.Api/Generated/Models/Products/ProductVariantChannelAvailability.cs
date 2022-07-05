namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductVariantChannelAvailability : IProductVariantChannelAvailability
    {
        public bool? IsOnStock { get; set; }

        public long? RestockableInDays { get; set; }

        public long? AvailableQuantity { get; set; }
    }
}
