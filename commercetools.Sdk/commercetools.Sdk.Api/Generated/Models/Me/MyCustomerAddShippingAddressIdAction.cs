namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCustomerAddShippingAddressIdAction : IMyCustomerAddShippingAddressIdAction
    {
        public string Action { get; set; }

        public string AddressId { get; set; }

        public string AddressKey { get; set; }
        public MyCustomerAddShippingAddressIdAction()
        {
            this.Action = "addShippingAddressId";
        }
    }
}
