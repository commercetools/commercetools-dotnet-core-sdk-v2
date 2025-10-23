using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.ProductVariantChannelAvailability))]
    public partial interface IProductVariantChannelAvailability
    {
        bool? IsOnStock { get; set; }

        long? RestockableInDays { get; set; }

        long? AvailableQuantity { get; set; }

        string Id { get; set; }

        long Version { get; set; }

    }
}
