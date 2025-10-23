using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetDiscountOnTotalPriceChange))]
    public partial interface ISetDiscountOnTotalPriceChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IDiscountOnTotalPrice PreviousValue { get; set; }

        IDiscountOnTotalPrice NextValue { get; set; }

    }
}
