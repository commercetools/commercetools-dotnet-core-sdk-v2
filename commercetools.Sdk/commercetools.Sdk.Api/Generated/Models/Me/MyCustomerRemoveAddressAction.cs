namespace commercetools.Sdk.Api.Models.Me
{
    public partial class MyCustomerRemoveAddressAction : IMyCustomerRemoveAddressAction
    {
        public string Action { get; set; }

        public string AddressId { get; set; }

        public string AddressKey { get; set; }
        public MyCustomerRemoveAddressAction()
        {
            this.Action = "removeAddress";
        }
    }
}
