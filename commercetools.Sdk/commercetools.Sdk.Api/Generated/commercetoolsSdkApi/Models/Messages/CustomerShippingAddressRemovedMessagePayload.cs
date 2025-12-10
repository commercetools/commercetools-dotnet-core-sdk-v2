using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerShippingAddressRemovedMessagePayload : ICustomerShippingAddressRemovedMessagePayload
    {
        public string Type { get; set; }

        public IAddress Address { get; set; }
        public CustomerShippingAddressRemovedMessagePayload()
        {
            this.Type = "CustomerShippingAddressRemoved";
        }
    }
}
