using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemDiscountedPriceChange))]
    public partial interface ISetLineItemDiscountedPriceChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ILocalizedString LineItem { get; set; }

        string Variant { get; set; }

        IDiscountedLineItemPrice NextValue { get; set; }

        IDiscountedLineItemPrice PreviousValue { get; set; }
    }
}
