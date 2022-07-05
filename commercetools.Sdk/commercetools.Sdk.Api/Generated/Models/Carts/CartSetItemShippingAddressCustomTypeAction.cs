using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetItemShippingAddressCustomTypeAction : ICartSetItemShippingAddressCustomTypeAction
    {
        public string Action { get; set; }

        public string AddressKey { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public CartSetItemShippingAddressCustomTypeAction()
        {
            this.Action = "setItemShippingAddressCustomType";
        }
    }
}
