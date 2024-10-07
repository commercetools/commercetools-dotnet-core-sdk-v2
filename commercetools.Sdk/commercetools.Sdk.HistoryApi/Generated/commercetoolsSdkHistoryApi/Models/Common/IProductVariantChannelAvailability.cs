using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.ProductVariantChannelAvailability))]
    public partial interface IProductVariantChannelAvailability
    {
        bool IsOnStock { get; set; }

        int RestockableInDays { get; set; }

        int AvailableQuantity { get; set; }

    }
}
