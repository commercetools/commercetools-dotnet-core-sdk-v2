namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    public partial class SetApplicationVersionChange : ISetApplicationVersionChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public int PreviousValue { get; set; }

        public int NextValue { get; set; }
        public SetApplicationVersionChange()
        {
            this.Type = "SetApplicationVersionChange";
        }
    }
}
