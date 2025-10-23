using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemDiscountedPriceChange))]
    public partial interface ISetCustomLineItemDiscountedPriceChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        ILocalizedString CustomLineItem { get; set; }

        string CustomLineItemId { get; set; }

        IDiscountedLineItemPrice PreviousValue { get; set; }

        IDiscountedLineItemPrice NextValue { get; set; }

    }
}
