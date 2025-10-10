

namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{

    public partial class SetAutomatedReversalConfigurationUpdateAction : ISetAutomatedReversalConfigurationUpdateAction
    {
        public string Action { get; set; }

        public IAutomatedReversalConfiguration AutomatedReversalConfiguration { get; set; }
        public SetAutomatedReversalConfigurationUpdateAction()
        {
            this.Action = "setAutomatedReversalConfiguration";
        }
    }
}
