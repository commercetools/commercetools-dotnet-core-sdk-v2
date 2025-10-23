using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemTaxedPriceChange))]
    public partial interface ISetLineItemTaxedPriceChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ITaxedItemPrice PreviousValue { get; set; }

        ITaxedItemPrice NextValue { get; set; }

        ILocalizedString LineItem { get; set; }

        string LineItemId { get; set; }

        string Variant { get; set; }

    }
}
