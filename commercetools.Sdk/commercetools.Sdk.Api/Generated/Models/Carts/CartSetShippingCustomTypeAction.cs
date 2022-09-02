using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetShippingCustomTypeAction : ICartSetShippingCustomTypeAction
    {
        public string Action { get; set; }

        public string ShippingKey { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public CartSetShippingCustomTypeAction()
        {
            this.Action = "setShippingCustomType";
        }
    }
}
