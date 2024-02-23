using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{

    public partial class CartDiscountChangeNameAction : ICartDiscountChangeNameAction
    {
        public string Action { get; set; }

        public ILocalizedString Name { get; set; }
        public CartDiscountChangeNameAction()
        {
            this.Action = "changeName";
        }
    }
}
