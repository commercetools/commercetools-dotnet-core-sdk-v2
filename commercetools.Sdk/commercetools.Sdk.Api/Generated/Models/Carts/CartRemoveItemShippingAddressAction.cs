namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartRemoveItemShippingAddressAction : ICartRemoveItemShippingAddressAction
    {
        public string Action { get; set; }

        public string AddressKey { get; set; }
        public CartRemoveItemShippingAddressAction()
        {
            this.Action = "removeItemShippingAddress";
        }
    }
}
