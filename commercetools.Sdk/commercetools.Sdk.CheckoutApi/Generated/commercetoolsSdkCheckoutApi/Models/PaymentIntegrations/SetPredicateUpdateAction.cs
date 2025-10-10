

namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{

    public partial class SetPredicateUpdateAction : ISetPredicateUpdateAction
    {
        public string Action { get; set; }

        public string Predicate { get; set; }
        public SetPredicateUpdateAction()
        {
            this.Action = "setPredicate";
        }
    }
}
