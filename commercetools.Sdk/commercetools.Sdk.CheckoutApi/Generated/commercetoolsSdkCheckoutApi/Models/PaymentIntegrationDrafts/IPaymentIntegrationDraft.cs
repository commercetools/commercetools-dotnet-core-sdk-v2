using commercetools.Sdk.CheckoutApi.Models.Applications;
using commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrationDrafts
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrationDrafts.PaymentIntegrationDraft))]
    public partial interface IPaymentIntegrationDraft
    {
        string Key { get; set; }

        IApplicationReference Application { get; set; }

        IPaymentIntegrationStatus Status { get; set; }

        string Type { get; set; }

        string Name { get; set; }

        string Predicate { get; set; }

        IPaymentComponentType ComponentType { get; set; }

        IConnectorDeploymentReference ConnectorDeployment { get; set; }

        IDisplayInfo DisplayInfo { get; set; }

        ISortingInfo SortingInfo { get; set; }

        IAutomatedReversalConfiguration AutomatedReversalConfiguration { get; set; }

    }
}
