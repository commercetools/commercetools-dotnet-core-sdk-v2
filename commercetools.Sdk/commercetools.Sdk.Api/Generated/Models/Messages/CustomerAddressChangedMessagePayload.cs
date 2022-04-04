using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Messages
{
    public partial class CustomerAddressChangedMessagePayload : ICustomerAddressChangedMessagePayload
    {
        public string Type { get; set; }

        public IAddress Address { get; set; }
        public CustomerAddressChangedMessagePayload()
        {
            this.Type = "CustomerAddressChanged";
        }
    }
}
