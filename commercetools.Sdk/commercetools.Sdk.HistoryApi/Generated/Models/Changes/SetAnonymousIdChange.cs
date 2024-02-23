namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetAnonymousIdChange : ISetAnonymousIdChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string PreviousValue { get; set; }

        public string NextValue { get; set; }
        public SetAnonymousIdChange()
        {
            this.Type = "SetAnonymousIdChange";
        }
    }
}
