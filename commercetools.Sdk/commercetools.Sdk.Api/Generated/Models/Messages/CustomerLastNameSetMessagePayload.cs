namespace commercetools.Api.Models.Messages
{
    public partial class CustomerLastNameSetMessagePayload : ICustomerLastNameSetMessagePayload
    {
        public string Type { get; set; }

        public string LastName { get; set; }
        public CustomerLastNameSetMessagePayload()
        {
            this.Type = "CustomerLastNameSet";
        }
    }
}
