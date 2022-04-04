using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    public partial class CartDiscountSetCustomTypeAction : ICartDiscountSetCustomTypeAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public CartDiscountSetCustomTypeAction()
        {
            this.Action = "setCustomType";
        }
    }
}
