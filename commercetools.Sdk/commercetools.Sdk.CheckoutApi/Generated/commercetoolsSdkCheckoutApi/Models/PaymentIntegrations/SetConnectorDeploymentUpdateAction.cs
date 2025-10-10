

namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{

    public partial class SetConnectorDeploymentUpdateAction : ISetConnectorDeploymentUpdateAction
    {
        public string Action { get; set; }

        public IConnectorDeploymentReference ConnectorDeployment { get; set; }
        public SetConnectorDeploymentUpdateAction()
        {
            this.Action = "setConnectorDeployment";
        }
    }
}
