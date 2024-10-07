

namespace commercetools.Sdk.Api.Models.CartDiscounts
{

    public partial class CartDiscountChangeValueAction : ICartDiscountChangeValueAction
    {
        public string Action { get; set; }

        public ICartDiscountValueDraft Value { get; set; }
        public CartDiscountChangeValueAction()
        {
            this.Action = "changeValue";
        }
    }
}
