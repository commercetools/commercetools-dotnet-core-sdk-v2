namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetKeyChange : ISetKeyChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string PreviousValue { get; set; }

        public string NextValue { get; set; }
        public SetKeyChange()
        {
            this.Type = "SetKeyChange";
        }
    }
}
