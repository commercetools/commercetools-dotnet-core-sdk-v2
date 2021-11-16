using commercetools.Api.Models.Customers;


namespace commercetools.Api.Models.Common
{
    public partial class ClientLogging : IClientLogging
    {
        public string ClientId { get; set;}
        
        public string ExternalUserId { get; set;}
        
        public ICustomerReference Customer { get; set;}
        
        public string AnonymousId { get; set;}
    }
}
