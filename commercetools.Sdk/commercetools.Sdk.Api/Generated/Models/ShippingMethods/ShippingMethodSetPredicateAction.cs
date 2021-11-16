namespace commercetools.Api.Models.ShippingMethods
{
    public partial class ShippingMethodSetPredicateAction : IShippingMethodSetPredicateAction
    {
        public string Action { get; set; }

        public string Predicate { get; set; }
        public ShippingMethodSetPredicateAction()
        {
            this.Action = "setPredicate";
        }
    }
}
