using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeLineItemPublishedChange))]
    public partial interface IChangeLineItemPublishedChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IShoppingListLineItemValue LineItem { get; set; }

        bool PreviousValue { get; set; }

        bool NextValue { get; set; }

    }
}
