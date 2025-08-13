using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerDefaultBillingAddressSetMessagePayload : ICustomerDefaultBillingAddressSetMessagePayload
    {
        public string Type { get; set; }

        public IAddress Address { get; set; }
        public CustomerDefaultBillingAddressSetMessagePayload()
        {
            this.Type = "CustomerDefaultBillingAddressSet";
        }
    }
}
