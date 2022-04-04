using commercetools.Sdk.Api.Models.Customers;


namespace commercetools.Sdk.Api.Models.Messages
{
    public partial class CustomerCreatedMessagePayload : ICustomerCreatedMessagePayload
    {
        public string Type { get; set; }

        public ICustomer Customer { get; set; }
        public CustomerCreatedMessagePayload()
        {
            this.Type = "CustomerCreated";
        }
    }
}
