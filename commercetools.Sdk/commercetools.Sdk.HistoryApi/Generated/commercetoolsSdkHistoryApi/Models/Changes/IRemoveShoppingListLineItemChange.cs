using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveShoppingListLineItemChange))]
    public partial interface IRemoveShoppingListLineItemChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IShoppingListLineItem PreviousValue { get; set; }

        IShoppingListLineItem NextValue { get; set; }

    }
}
