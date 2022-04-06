namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    public partial class SetMaxApplicationsPerCustomerChange : ISetMaxApplicationsPerCustomerChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public int PreviousValue { get; set; }

        public int NextValue { get; set; }
        public SetMaxApplicationsPerCustomerChange()
        {
            this.Type = "SetMaxApplicationsPerCustomerChange";
        }
    }
}
