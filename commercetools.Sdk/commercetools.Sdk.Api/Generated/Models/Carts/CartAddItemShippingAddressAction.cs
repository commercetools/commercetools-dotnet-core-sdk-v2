using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartAddItemShippingAddressAction : ICartAddItemShippingAddressAction
    {
        public string Action { get; set; }

        public IBaseAddress Address { get; set; }
        public CartAddItemShippingAddressAction()
        {
            this.Action = "addItemShippingAddress";
        }
    }
}
