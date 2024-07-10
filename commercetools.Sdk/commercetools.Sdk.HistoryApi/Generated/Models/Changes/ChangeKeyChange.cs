namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeKeyChange : IChangeKeyChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string PreviousValue { get; set; }

        public string NextValue { get; set; }
        public ChangeKeyChange()
        {
            this.Type = "ChangeKeyChange";
        }
    }
}
