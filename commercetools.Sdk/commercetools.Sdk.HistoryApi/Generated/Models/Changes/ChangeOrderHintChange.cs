namespace commercetools.HistoryApi.Models.Changes
{
    public partial class ChangeOrderHintChange : IChangeOrderHintChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string PreviousValue { get; set; }

        public string NextValue { get; set; }
        public ChangeOrderHintChange()
        {
            this.Type = "ChangeOrderHintChange";
        }
    }
}
