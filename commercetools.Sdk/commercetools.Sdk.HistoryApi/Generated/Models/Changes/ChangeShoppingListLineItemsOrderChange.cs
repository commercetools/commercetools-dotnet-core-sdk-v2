using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Changes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
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
