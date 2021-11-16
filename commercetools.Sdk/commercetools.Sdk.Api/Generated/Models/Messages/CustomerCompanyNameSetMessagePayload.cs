namespace commercetools.Api.Models.Messages
{
    public partial class CustomerCompanyNameSetMessagePayload : ICustomerCompanyNameSetMessagePayload
    {
        public string Type { get; set;}
        
        public string CompanyName { get; set;}
        public CustomerCompanyNameSetMessagePayload()
        { 
           this.Type = "CustomerCompanyNameSet";
        }
    }
}
