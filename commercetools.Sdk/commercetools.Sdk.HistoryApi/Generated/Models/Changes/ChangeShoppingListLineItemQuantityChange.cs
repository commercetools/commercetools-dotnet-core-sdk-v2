using commercetools.HistoryApi.Models.ChangeValues;


namespace commercetools.HistoryApi.Models.Changes
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
