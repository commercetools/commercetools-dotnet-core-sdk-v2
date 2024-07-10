using commercetools.Sdk.HistoryApi.Models.ChangeValues;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetLineItemDeactivatedAtChange : ISetLineItemDeactivatedAtChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string PreviousValue { get; set; }

        public string NextValue { get; set; }

        public IShoppingListLineItemValue LineItem { get; set; }
        public SetLineItemDeactivatedAtChange()
        {
            this.Type = "SetLineItemDeactivatedAtChange";
        }
    }
}
