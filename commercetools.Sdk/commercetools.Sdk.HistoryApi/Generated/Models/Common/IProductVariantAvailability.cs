using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.ProductVariantAvailability))]
    public partial interface IProductVariantAvailability
    {
        bool IsOnStock { get; set; }

        int RestockableInDays { get; set; }

        int AvailableQuantity { get; set; }

        IProductVariantChannelAvailabilityMap Channels { get; set; }
    }
}
