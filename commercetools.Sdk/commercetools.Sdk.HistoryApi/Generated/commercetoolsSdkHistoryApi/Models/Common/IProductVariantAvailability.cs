using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.ProductVariantAvailability))]
    public partial interface IProductVariantAvailability
    {
        IProductVariantChannelAvailabilityMap Channels { get; set; }

        bool? IsOnStock { get; set; }

        long? RestockableInDays { get; set; }

        long? AvailableQuantity { get; set; }

        string Id { get; set; }

        long? Version { get; set; }

    }
}
