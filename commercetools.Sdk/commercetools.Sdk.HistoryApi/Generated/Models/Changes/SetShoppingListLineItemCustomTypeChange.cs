using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    public partial class SetShoppingListLineItemCustomTypeChange : ISetShoppingListLineItemCustomTypeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IShoppingListLineItemValue LineItem { get; set; }

        public ICustomFields NextValue { get; set; }

        public ICustomFields PreviousValue { get; set; }
        public SetShoppingListLineItemCustomTypeChange()
        {
            this.Type = "SetShoppingListLineItemCustomTypeChange";
        }
    }
}
