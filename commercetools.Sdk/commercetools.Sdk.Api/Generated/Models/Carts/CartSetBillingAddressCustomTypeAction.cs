using commercetools.Api.Models.Types;


namespace commercetools.Api.Models.Carts
{
    public partial class CartSetBillingAddressCustomTypeAction : ICartSetBillingAddressCustomTypeAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public CartSetBillingAddressCustomTypeAction()
        {
            this.Action = "setBillingAddressCustomType";
        }
    }
}
