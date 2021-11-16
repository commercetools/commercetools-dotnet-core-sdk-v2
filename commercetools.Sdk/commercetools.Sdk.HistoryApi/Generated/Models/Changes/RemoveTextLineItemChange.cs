using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class RemoveTextLineItemChange : IRemoveTextLineItemChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ITextLineItem PreviousValue { get; set; }

        public ITextLineItem NextValue { get; set; }
        public RemoveTextLineItemChange()
        {
            this.Type = "RemoveTextLineItemChange";
        }
    }
}
