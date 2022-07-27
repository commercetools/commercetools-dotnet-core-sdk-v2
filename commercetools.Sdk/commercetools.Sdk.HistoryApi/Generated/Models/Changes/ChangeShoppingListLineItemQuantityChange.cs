using commercetools.Sdk.HistoryApi.Models.ChangeValues;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeShoppingListLineItemQuantityChange : IChangeShoppingListLineItemQuantityChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IShoppingListLineItemValue LineItem { get; set; }

        public int PreviousValue { get; set; }

        public int NextValue { get; set; }
        public ChangeShoppingListLineItemQuantityChange()
        {
            this.Type = "ChangeShoppingListLineItemQuantityChange";
        }
    }
}
