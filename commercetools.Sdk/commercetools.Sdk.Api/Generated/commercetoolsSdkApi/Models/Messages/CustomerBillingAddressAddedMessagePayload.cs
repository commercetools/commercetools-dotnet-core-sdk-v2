using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerBillingAddressAddedMessagePayload : ICustomerBillingAddressAddedMessagePayload
    {
        public string Type { get; set; }

        public IAddress Address { get; set; }
        public CustomerBillingAddressAddedMessagePayload()
        {
            this.Type = "CustomerBillingAddressAdded";
        }
    }
}
