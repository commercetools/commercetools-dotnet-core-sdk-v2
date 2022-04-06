namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    public partial class ChangePredicateChange : IChangePredicateChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string PreviousValue { get; set; }

        public string NextValue { get; set; }
        public ChangePredicateChange()
        {
            this.Type = "ChangePredicateChange";
        }
    }
}
