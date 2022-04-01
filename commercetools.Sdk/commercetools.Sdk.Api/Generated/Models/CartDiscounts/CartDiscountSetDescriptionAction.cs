using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    public partial class CartDiscountSetDescriptionAction : ICartDiscountSetDescriptionAction
    {
        public string Action { get; set; }

        public ILocalizedString Description { get; set; }
        public CartDiscountSetDescriptionAction()
        {
            this.Action = "setDescription";
        }
    }
}
