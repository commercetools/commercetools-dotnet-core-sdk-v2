namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    public partial class SetIsValidChange : ISetIsValidChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public bool PreviousValue { get; set; }

        public bool NextValue { get; set; }
        public SetIsValidChange()
        {
            this.Type = "SetIsValidChange";
        }
    }
}
