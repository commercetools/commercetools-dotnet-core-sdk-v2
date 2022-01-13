using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.ChangeShoppingListLineItemQuantityChange))]
    public partial interface IChangeShoppingListLineItemQuantityChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IShoppingListLineItemValue LineItem { get; set; }

        int PreviousValue { get; set; }

        int NextValue { get; set; }
    }
}
