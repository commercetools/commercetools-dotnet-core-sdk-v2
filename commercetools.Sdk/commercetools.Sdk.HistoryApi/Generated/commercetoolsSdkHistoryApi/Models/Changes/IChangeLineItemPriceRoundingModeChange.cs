using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeLineItemPriceRoundingModeChange))]
    public partial interface IChangeLineItemPriceRoundingModeChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        string Variant { get; set; }

        ILocalizedString LineItem { get; set; }

        string LineItemId { get; set; }

        IRoundingMode PreviousValue { get; set; }

        IRoundingMode NextValue { get; set; }

    }
}
