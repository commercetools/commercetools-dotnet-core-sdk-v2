using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Carts
{
    public partial class CartSetShippingAddressAction : ICartSetShippingAddressAction
    {
        public string Action { get; set; }

        public IBaseAddress Address { get; set; }
        public CartSetShippingAddressAction()
        {
            this.Action = "setShippingAddress";
        }
    }
}
