namespace commercetools.Api.Models.Customers
{
    public partial class CustomerRemoveBillingAddressIdAction : ICustomerRemoveBillingAddressIdAction
    {
        public string Action { get; set; }

        public string AddressId { get; set; }

        public string AddressKey { get; set; }
        public CustomerRemoveBillingAddressIdAction()
        {
            this.Action = "removeBillingAddressId";
        }
    }
}
