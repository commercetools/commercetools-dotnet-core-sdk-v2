namespace commercetools.HistoryApi.Models.Changes
{
    public partial class ChangeNameChange : IChangeNameChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string PreviousValue { get; set; }

        public string NextValue { get; set; }
        public ChangeNameChange()
        {
            this.Type = "ChangeNameChange";
        }
    }
}
