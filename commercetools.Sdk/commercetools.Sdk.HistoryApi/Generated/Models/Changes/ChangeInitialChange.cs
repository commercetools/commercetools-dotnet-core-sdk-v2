namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    public partial class ChangeInitialChange : IChangeInitialChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public bool PreviousValue { get; set; }

        public bool NextValue { get; set; }
        public ChangeInitialChange()
        {
            this.Type = "ChangeInitialChange";
        }
    }
}
