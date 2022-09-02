namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartRemoveShippingMethodAction : ICartRemoveShippingMethodAction
    {
        public string Action { get; set; }

        public string ShippingKey { get; set; }
        public CartRemoveShippingMethodAction()
        {
            this.Action = "removeShippingMethod";
        }
    }
}
