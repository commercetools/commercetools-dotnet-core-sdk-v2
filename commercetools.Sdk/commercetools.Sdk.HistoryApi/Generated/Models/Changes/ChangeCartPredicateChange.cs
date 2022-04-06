namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    public partial class ChangeCartPredicateChange : IChangeCartPredicateChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string PreviousValue { get; set; }

        public string NextValue { get; set; }
        public ChangeCartPredicateChange()
        {
            this.Type = "ChangeCartPredicateChange";
        }
    }
}
