using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetDiscountedPriceChange))]
    public partial interface ISetDiscountedPriceChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IDiscountedPrice PreviousValue { get; set; }

        IDiscountedPrice NextValue { get; set; }

        string CatalogData { get; set; }

        string Variant { get; set; }

        string PriceId { get; set; }

        IPrice Price { get; set; }

    }
}
