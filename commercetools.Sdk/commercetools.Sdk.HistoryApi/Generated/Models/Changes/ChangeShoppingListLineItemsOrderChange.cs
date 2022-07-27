using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using System.Collections.Generic;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeShoppingListLineItemsOrderChange : IChangeShoppingListLineItemsOrderChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public List<IShoppingListLineItemValue> PreviousValue { get; set; }

        public List<IShoppingListLineItemValue> NextValue { get; set; }
        public ChangeShoppingListLineItemsOrderChange()
        {
            this.Type = "ChangeShoppingListLineItemsOrderChange";
        }
    }
}
