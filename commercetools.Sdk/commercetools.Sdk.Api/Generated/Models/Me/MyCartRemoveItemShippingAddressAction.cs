namespace commercetools.Api.Models.Me
{
    public partial class MyCartRemoveItemShippingAddressAction : IMyCartRemoveItemShippingAddressAction
    {
        public string Action { get; set; }

        public string AddressKey { get; set; }
        public MyCartRemoveItemShippingAddressAction()
        {
            this.Action = "removeItemShippingAddress";
        }
    }
}
