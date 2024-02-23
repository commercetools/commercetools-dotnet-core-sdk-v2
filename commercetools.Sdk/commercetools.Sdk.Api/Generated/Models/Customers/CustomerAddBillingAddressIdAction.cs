namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerAddBillingAddressIdAction : ICustomerAddBillingAddressIdAction
    {
        public string Action { get; set; }

        public string AddressId { get; set; }

        public string AddressKey { get; set; }
        public CustomerAddBillingAddressIdAction()
        {
            this.Action = "addBillingAddressId";
        }
    }
}
