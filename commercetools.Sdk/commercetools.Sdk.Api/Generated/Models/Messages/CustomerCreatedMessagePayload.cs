using commercetools.Api.Models.Customers;


namespace commercetools.Api.Models.Messages
{
    public partial class CustomerCreatedMessagePayload : ICustomerCreatedMessagePayload
    {
        public string Type { get; set;}
        
        public ICustomer Customer { get; set;}
        public CustomerCreatedMessagePayload()
        { 
           this.Type = "CustomerCreated";
        }
    }
}
