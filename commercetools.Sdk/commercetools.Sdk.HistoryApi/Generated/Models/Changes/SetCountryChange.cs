namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetCountryChange : ISetCountryChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string PreviousValue { get; set; }

        public string NextValue { get; set; }
        public SetCountryChange()
        {
            this.Type = "SetCountryChange";
        }
    }
}
