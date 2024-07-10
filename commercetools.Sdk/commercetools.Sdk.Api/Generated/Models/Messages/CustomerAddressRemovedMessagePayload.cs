using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerAddressRemovedMessagePayload : ICustomerAddressRemovedMessagePayload
    {
        public string Type { get; set; }

        public IAddress Address { get; set; }
        public CustomerAddressRemovedMessagePayload()
        {
            this.Type = "CustomerAddressRemoved";
        }
    }
}
