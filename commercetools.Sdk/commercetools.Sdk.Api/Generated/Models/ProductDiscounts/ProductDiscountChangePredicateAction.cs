namespace commercetools.Sdk.Api.Models.ProductDiscounts
{

    public partial class ProductDiscountChangePredicateAction : IProductDiscountChangePredicateAction
    {
        public string Action { get; set; }

        public string Predicate { get; set; }
        public ProductDiscountChangePredicateAction()
        {
            this.Action = "changePredicate";
        }
    }
}
