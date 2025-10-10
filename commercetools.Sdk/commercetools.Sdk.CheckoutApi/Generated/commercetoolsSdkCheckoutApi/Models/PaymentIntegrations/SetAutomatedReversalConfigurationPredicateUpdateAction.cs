

namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{

    public partial class SetAutomatedReversalConfigurationPredicateUpdateAction : ISetAutomatedReversalConfigurationPredicateUpdateAction
    {
        public string Action { get; set; }

        public string Predicate { get; set; }
        public SetAutomatedReversalConfigurationPredicateUpdateAction()
        {
            this.Action = "setAutomatedReversalConfigurationPredicate";
        }
    }
}
