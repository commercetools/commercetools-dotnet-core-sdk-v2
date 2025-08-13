using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerDefaultShippingAddressSetMessagePayload : ICustomerDefaultShippingAddressSetMessagePayload
    {
        public string Type { get; set; }

        public IAddress Address { get; set; }
        public CustomerDefaultShippingAddressSetMessagePayload()
        {
            this.Type = "CustomerDefaultShippingAddressSet";
        }
    }
}
