namespace commercetools.Sdk.Api.Models.DiscountCodes
{

    public partial class DiscountCodeSetCartPredicateAction : IDiscountCodeSetCartPredicateAction
    {
        public string Action { get; set; }

        public string CartPredicate { get; set; }
        public DiscountCodeSetCartPredicateAction()
        {
            this.Action = "setCartPredicate";
        }
    }
}
