namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetCustomerNumberChange : ISetCustomerNumberChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string PreviousValue { get; set; }

        public string NextValue { get; set; }
        public SetCustomerNumberChange()
        {
            this.Type = "SetCustomerNumberChange";
        }
    }
}
