using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerBillingAddressRemovedMessagePayload : ICustomerBillingAddressRemovedMessagePayload
    {
        public string Type { get; set; }

        public IAddress Address { get; set; }
        public CustomerBillingAddressRemovedMessagePayload()
        {
            this.Type = "CustomerBillingAddressRemoved";
        }
    }
}
