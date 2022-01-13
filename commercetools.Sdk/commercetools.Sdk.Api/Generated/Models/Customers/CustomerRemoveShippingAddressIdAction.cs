namespace commercetools.Api.Models.Customers
{
    public partial class CustomerRemoveShippingAddressIdAction : ICustomerRemoveShippingAddressIdAction
    {
        public string Action { get; set; }

        public string AddressId { get; set; }

        public string AddressKey { get; set; }
        public CustomerRemoveShippingAddressIdAction()
        {
            this.Action = "removeShippingAddressId";
        }
    }
}
