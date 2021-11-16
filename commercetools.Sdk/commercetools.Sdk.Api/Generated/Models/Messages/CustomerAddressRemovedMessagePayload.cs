using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Messages
{
    public partial class CustomerAddressRemovedMessagePayload : ICustomerAddressRemovedMessagePayload
    {
        public string Type { get; set;}
        
        public IAddress Address { get; set;}
        public CustomerAddressRemovedMessagePayload()
        { 
           this.Type = "CustomerAddressRemoved";
        }
    }
}
