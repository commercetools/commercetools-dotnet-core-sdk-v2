using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.StandalonePriceSetDiscountedPriceChange))]
    public partial interface IStandalonePriceSetDiscountedPriceChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        bool Staged { get; set; }

        IDiscountedPrice PreviousValue { get; set; }

        IDiscountedPrice NextValue { get; set; }

    }
}
