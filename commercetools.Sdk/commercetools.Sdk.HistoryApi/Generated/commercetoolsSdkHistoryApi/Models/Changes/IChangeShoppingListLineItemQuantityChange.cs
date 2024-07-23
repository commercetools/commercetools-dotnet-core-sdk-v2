using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeShoppingListLineItemQuantityChange))]
    public partial interface IChangeShoppingListLineItemQuantityChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        int PreviousValue { get; set; }

        int NextValue { get; set; }

        IShoppingListLineItemValue LineItem { get; set; }

    }
}
