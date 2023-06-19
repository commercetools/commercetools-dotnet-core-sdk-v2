using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemDiscountedPriceChange))]
    public partial interface ISetLineItemDiscountedPriceChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IDiscountedLineItemPrice PreviousValue { get; set; }

        IDiscountedLineItemPrice NextValue { get; set; }

        ILocalizedString LineItem { get; set; }

        string Variant { get; set; }

    }
}
