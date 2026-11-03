

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeSavedToLineItemChange : IChangeSavedToLineItemChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public bool PreviousValue { get; set; }

        public bool NextValue { get; set; }

        public string AttributeName { get; set; }
        public ChangeSavedToLineItemChange()
        {
            this.Type = "ChangeSavedToLineItemChange";
        }
    }
}
