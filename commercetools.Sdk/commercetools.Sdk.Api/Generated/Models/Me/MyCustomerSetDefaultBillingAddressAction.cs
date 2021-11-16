namespace commercetools.Api.Models.Me
{
    public partial class MyCustomerSetDefaultBillingAddressAction : IMyCustomerSetDefaultBillingAddressAction
    {
        public string Action { get; set; }

        public string AddressId { get; set; }

        public string AddressKey { get; set; }
        public MyCustomerSetDefaultBillingAddressAction()
        {
            this.Action = "setDefaultBillingAddress";
        }
    }
}
