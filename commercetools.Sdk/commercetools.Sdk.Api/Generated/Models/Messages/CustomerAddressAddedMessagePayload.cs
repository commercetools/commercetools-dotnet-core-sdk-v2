using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Messages
{
    public partial class CustomerAddressAddedMessagePayload : ICustomerAddressAddedMessagePayload
    {
        public string Type { get; set; }

        public IAddress Address { get; set; }
        public CustomerAddressAddedMessagePayload()
        {
            this.Type = "CustomerAddressAdded";
        }
    }
}
