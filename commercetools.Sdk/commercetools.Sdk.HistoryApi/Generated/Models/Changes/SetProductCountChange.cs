namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetProductCountChange : ISetProductCountChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public int PreviousValue { get; set; }

        public int NextValue { get; set; }
        public SetProductCountChange()
        {
            this.Type = "SetProductCountChange";
        }
    }
}
