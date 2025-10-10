using commercetools.Sdk.CheckoutApi.Models.Applications;
using commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations;


namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrationDrafts
{

    public partial class PaymentIntegrationDraft : IPaymentIntegrationDraft
    {
        public string Key { get; set; }

        public IApplicationReference Application { get; set; }

        public IPaymentIntegrationStatus Status { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public string Predicate { get; set; }

        public IPaymentComponentType ComponentType { get; set; }

        public IConnectorDeploymentReference ConnectorDeployment { get; set; }

        public IDisplayInfo DisplayInfo { get; set; }

        public ISortingInfo SortingInfo { get; set; }

        public IAutomatedReversalConfiguration AutomatedReversalConfiguration { get; set; }
    }
}
