using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeTargetMultiBuyLineItemsChangeValue))]
    public partial interface IChangeTargetMultiBuyLineItemsChangeValue : IChangeTargetChangeValue
    {
        new string Type { get; set; }

        string Predicate { get; set; }

        int TriggerQuantity { get; set; }

        int DiscountedQuantity { get; set; }

        int MaxOccurrence { get; set; }

        ISelectionMode SelectionMode { get; set; }

    }
}
