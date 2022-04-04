namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    public partial class CartDiscountChangeCartPredicateAction : ICartDiscountChangeCartPredicateAction
    {
        public string Action { get; set; }

        public string CartPredicate { get; set; }
        public CartDiscountChangeCartPredicateAction()
        {
            this.Action = "changeCartPredicate";
        }
    }
}
