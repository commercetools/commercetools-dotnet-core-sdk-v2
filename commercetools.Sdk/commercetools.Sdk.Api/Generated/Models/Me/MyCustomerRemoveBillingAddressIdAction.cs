namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCustomerRemoveBillingAddressIdAction : IMyCustomerRemoveBillingAddressIdAction
    {
        public string Action { get; set; }

        public string AddressId { get; set; }

        public string AddressKey { get; set; }
        public MyCustomerRemoveBillingAddressIdAction()
        {
            this.Action = "removeBillingAddressId";
        }
    }
}
