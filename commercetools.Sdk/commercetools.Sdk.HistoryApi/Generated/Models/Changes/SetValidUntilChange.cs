namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    public partial class SetValidUntilChange : ISetValidUntilChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string PreviousValue { get; set; }

        public string NextValue { get; set; }
        public SetValidUntilChange()
        {
            this.Type = "SetValidUntilChange";
        }
    }
}
