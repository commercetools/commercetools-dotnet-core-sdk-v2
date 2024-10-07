using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using System;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetShoppingListLineItemCustomFieldChange : ISetShoppingListLineItemCustomFieldChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public Object PreviousValue { get; set; }

        public Object NextValue { get; set; }

        public string Name { get; set; }

        public string CustomTypeId { get; set; }

        public IShoppingListLineItemValue LineItem { get; set; }
        public SetShoppingListLineItemCustomFieldChange()
        {
            this.Type = "SetShoppingListLineItemCustomFieldChange";
        }
    }
}
