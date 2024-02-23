using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeShoppingListLineItemsOrderChange : IChangeShoppingListLineItemsOrderChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<IShoppingListLineItemValue> PreviousValue { get; set; }
        public IEnumerable<IShoppingListLineItemValue> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


        public IList<IShoppingListLineItemValue> NextValue { get; set; }
        public IEnumerable<IShoppingListLineItemValue> NextValueEnumerable { set => NextValue = value.ToList(); }

        public ChangeShoppingListLineItemsOrderChange()
        {
            this.Type = "ChangeShoppingListLineItemsOrderChange";
        }
    }
}
