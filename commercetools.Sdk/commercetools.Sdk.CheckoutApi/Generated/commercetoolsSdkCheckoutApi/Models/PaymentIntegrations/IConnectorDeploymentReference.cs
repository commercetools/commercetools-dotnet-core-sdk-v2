using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.ConnectorDeploymentReference))]
    public partial interface IConnectorDeploymentReference
    {
        string Id { get; set; }

        string TypeId { get; set; }

    }
}
