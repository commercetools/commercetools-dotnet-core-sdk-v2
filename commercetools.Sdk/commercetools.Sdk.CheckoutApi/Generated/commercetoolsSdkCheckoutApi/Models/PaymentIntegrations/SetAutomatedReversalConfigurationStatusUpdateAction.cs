

namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{

    public partial class SetAutomatedReversalConfigurationStatusUpdateAction : ISetAutomatedReversalConfigurationStatusUpdateAction
    {
        public string Action { get; set; }

        public string Status { get; set; }
        public SetAutomatedReversalConfigurationStatusUpdateAction()
        {
            this.Action = "setAutomatedReversalConfigurationStatus";
        }
    }
}
