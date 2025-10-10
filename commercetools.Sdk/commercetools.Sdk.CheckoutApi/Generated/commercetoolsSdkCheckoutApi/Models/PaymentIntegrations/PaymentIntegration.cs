using commercetools.Sdk.CheckoutApi.Models.Applications;
using System;

namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{

    public partial class PaymentIntegration : IPaymentIntegration
    {
        public string Id { get; set; }

        public long Version { get; set; }

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

        public DateTime CreatedAt { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }
    }
}
