

namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCustomerRemoveShippingAddressIdAction : IMyCustomerRemoveShippingAddressIdAction
    {
        public string Action { get; set; }

        public string AddressId { get; set; }

        public string AddressKey { get; set; }
        public MyCustomerRemoveShippingAddressIdAction()
        {
            this.Action = "removeShippingAddressId";
        }
    }
}
