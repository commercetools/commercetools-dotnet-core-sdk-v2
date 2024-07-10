namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetLastNameChange : ISetLastNameChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string PreviousValue { get; set; }

        public string NextValue { get; set; }
        public SetLastNameChange()
        {
            this.Type = "SetLastNameChange";
        }
    }
}
