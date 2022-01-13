namespace commercetools.Api.Models.Customers
{
    public partial class CustomerRemoveAddressAction : ICustomerRemoveAddressAction
    {
        public string Action { get; set; }

        public string AddressId { get; set; }

        public string AddressKey { get; set; }
        public CustomerRemoveAddressAction()
        {
            this.Action = "removeAddress";
        }
    }
}
