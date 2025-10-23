using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemDiscountedPricePerQuantityChange))]
    public partial interface ISetCustomLineItemDiscountedPricePerQuantityChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        ILocalizedString CustomLineItem { get; set; }

        string CustomLineItemId { get; set; }

        IDiscountedLineItemPriceForQuantity PreviousValue { get; set; }

        IDiscountedLineItemPriceForQuantity NextValue { get; set; }

    }
}
