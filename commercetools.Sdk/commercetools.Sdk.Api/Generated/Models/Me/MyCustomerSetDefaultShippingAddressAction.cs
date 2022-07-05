namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCustomerSetDefaultShippingAddressAction : IMyCustomerSetDefaultShippingAddressAction
    {
        public string Action { get; set; }

        public string AddressId { get; set; }

        public string AddressKey { get; set; }
        public MyCustomerSetDefaultShippingAddressAction()
        {
            this.Action = "setDefaultShippingAddress";
        }
    }
}
