namespace commercetools.Sdk.Api.Models.CartDiscounts
{

    public partial class CartDiscountChangeStackingModeAction : ICartDiscountChangeStackingModeAction
    {
        public string Action { get; set; }

        public IStackingMode StackingMode { get; set; }
        public CartDiscountChangeStackingModeAction()
        {
            this.Action = "changeStackingMode";
        }
    }
}
