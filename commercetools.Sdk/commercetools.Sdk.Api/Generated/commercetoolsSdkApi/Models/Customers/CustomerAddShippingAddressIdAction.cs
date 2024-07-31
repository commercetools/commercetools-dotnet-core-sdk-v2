

namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerAddShippingAddressIdAction : ICustomerAddShippingAddressIdAction
    {
        public string Action { get; set; }

        public string AddressId { get; set; }

        public string AddressKey { get; set; }
        public CustomerAddShippingAddressIdAction()
        {
            this.Action = "addShippingAddressId";
        }
    }
}
