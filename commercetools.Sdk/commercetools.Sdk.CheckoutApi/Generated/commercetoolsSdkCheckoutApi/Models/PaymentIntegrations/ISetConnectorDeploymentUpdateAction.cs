using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetConnectorDeploymentUpdateAction))]
    public partial interface ISetConnectorDeploymentUpdateAction : IPaymentIntegrationUpdateAction
    {
        IConnectorDeploymentReference ConnectorDeployment { get; set; }

    }
}
