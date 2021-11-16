using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Carts
{
    public partial class CartSetBillingAddressAction : ICartSetBillingAddressAction
    {
        public string Action { get; set; }

        public IBaseAddress Address { get; set; }
        public CartSetBillingAddressAction()
        {
            this.Action = "setBillingAddress";
        }
    }
}
