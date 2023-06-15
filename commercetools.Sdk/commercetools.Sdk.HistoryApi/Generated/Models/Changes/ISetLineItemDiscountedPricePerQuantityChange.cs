using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemDiscountedPricePerQuantityChange))]
    public partial interface ISetLineItemDiscountedPricePerQuantityChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IDiscountedLineItemPriceForQuantity PreviousValue { get; set; }

        IDiscountedLineItemPriceForQuantity NextValue { get; set; }

        ILocalizedString LineItem { get; set; }

        string Variant { get; set; }

    }
}
