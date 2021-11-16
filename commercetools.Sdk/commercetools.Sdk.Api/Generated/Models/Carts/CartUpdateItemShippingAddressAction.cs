using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Carts
{
    public partial class CartUpdateItemShippingAddressAction : ICartUpdateItemShippingAddressAction
    {
        public string Action { get; set; }

        public IBaseAddress Address { get; set; }
        public CartUpdateItemShippingAddressAction()
        {
            this.Action = "updateItemShippingAddress";
        }
    }
}
