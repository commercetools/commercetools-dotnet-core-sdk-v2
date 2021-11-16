namespace commercetools.Api.Models.Messages
{
    public partial class CustomerPasswordUpdatedMessagePayload : ICustomerPasswordUpdatedMessagePayload
    {
        public string Type { get; set;}
        
        public bool Reset { get; set;}
        public CustomerPasswordUpdatedMessagePayload()
        { 
           this.Type = "CustomerPasswordUpdated";
        }
    }
}
