using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Messages
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
