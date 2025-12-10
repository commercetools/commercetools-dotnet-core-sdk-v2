using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerShippingAddressAddedMessagePayload : ICustomerShippingAddressAddedMessagePayload
    {
        public string Type { get; set; }

        public IAddress Address { get; set; }
        public CustomerShippingAddressAddedMessagePayload()
        {
            this.Type = "CustomerShippingAddressAdded";
        }
    }
}
