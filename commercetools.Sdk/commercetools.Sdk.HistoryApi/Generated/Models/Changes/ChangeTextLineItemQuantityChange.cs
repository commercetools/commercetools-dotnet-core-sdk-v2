using commercetools.Sdk.HistoryApi.Models.ChangeValues;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    public partial class ChangeTextLineItemQuantityChange : IChangeTextLineItemQuantityChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ITextLineItemValue TextLineItem { get; set; }

        public int PreviousValue { get; set; }

        public int NextValue { get; set; }
        public ChangeTextLineItemQuantityChange()
        {
            this.Type = "ChangeTextLineItemQuantityChange";
        }
    }
}
