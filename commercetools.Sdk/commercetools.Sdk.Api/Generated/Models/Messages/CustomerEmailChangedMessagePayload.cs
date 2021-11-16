namespace commercetools.Api.Models.Messages
{
    public partial class CustomerEmailChangedMessagePayload : ICustomerEmailChangedMessagePayload
    {
        public string Type { get; set;}
        
        public string Email { get; set;}
        public CustomerEmailChangedMessagePayload()
        { 
           this.Type = "CustomerEmailChanged";
        }
    }
}
