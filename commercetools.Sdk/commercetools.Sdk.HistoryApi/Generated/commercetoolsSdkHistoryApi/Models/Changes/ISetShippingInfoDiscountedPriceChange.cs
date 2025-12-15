using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetShippingInfoDiscountedPriceChange))]
    public partial interface ISetShippingInfoDiscountedPriceChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IDiscountedLineItemPrice PreviousValue { get; set; }

        IDiscountedLineItemPrice NextValue { get; set; }

    }
}
