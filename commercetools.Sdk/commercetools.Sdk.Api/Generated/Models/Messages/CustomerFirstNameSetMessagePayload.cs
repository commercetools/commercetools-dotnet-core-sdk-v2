namespace commercetools.Api.Models.Messages
{
    public partial class CustomerFirstNameSetMessagePayload : ICustomerFirstNameSetMessagePayload
    {
        public string Type { get; set;}
        
        public string FirstName { get; set;}
        public CustomerFirstNameSetMessagePayload()
        { 
           this.Type = "CustomerFirstNameSet";
        }
    }
}
