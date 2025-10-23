using commercetools.Sdk.HistoryApi.Models.ChangeValues;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeLineItemPublishedChange : IChangeLineItemPublishedChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IShoppingListLineItemValue LineItem { get; set; }

        public bool PreviousValue { get; set; }

        public bool NextValue { get; set; }
        public ChangeLineItemPublishedChange()
        {
            this.Type = "ChangeLineItemPublishedChange";
        }
    }
}
