

namespace commercetools.Sdk.Api.Models.CartDiscounts
{

    public partial class CartDiscountChangeTargetAction : ICartDiscountChangeTargetAction
    {
        public string Action { get; set; }

        public ICartDiscountTarget Target { get; set; }
        public CartDiscountChangeTargetAction()
        {
            this.Action = "changeTarget";
        }
    }
}
