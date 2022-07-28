using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductVariantAvailability))]
    public partial interface IProductVariantAvailability
    {
        IProductVariantChannelAvailabilityMap Channels { get; set; }

        bool? IsOnStock { get; set; }

        long? RestockableInDays { get; set; }

        long? AvailableQuantity { get; set; }

    }
}
