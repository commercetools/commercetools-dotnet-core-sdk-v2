namespace commercetools.Sdk.HistoryApi.Models.Labels
{
    public partial class CustomerLabel : ICustomerLabel
    {
        public string Type { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string CustomerNumber { get; set; }
        public CustomerLabel()
        {
            this.Type = "CustomerLabel";
        }
    }
}
