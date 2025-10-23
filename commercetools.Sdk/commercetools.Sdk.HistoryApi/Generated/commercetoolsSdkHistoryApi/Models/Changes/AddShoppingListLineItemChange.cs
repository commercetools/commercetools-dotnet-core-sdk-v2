using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class AddShoppingListLineItemChange : IAddShoppingListLineItemChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IShoppingListLineItem PreviousValue { get; set; }

        public IShoppingListLineItem NextValue { get; set; }
        public AddShoppingListLineItemChange()
        {
            this.Type = "AddShoppingListLineItemChange";
        }
    }
}
