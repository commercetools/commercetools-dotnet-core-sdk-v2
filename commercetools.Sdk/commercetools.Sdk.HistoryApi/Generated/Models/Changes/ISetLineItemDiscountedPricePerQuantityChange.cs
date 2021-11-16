using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetLineItemDiscountedPricePerQuantityChange))]
    public partial interface ISetLineItemDiscountedPricePerQuantityChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ILocalizedString LineItem { get; set; }

        string Variant { get; set; }

        IDiscountedLineItemPriceForQuantity NextValue { get; set; }

        IDiscountedLineItemPriceForQuantity PreviousValue { get; set; }
    }
}
