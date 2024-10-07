

namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerSetDefaultBillingAddressAction : ICustomerSetDefaultBillingAddressAction
    {
        public string Action { get; set; }

        public string AddressId { get; set; }

        public string AddressKey { get; set; }
        public CustomerSetDefaultBillingAddressAction()
        {
            this.Action = "setDefaultBillingAddress";
        }
    }
}
