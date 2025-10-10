using commercetools.Sdk.CheckoutApi.Models.Applications;
using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.PaymentIntegration))]
    public partial interface IPaymentIntegration
    {
        string Id { get; set; }

        long Version { get; set; }

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

        DateTime CreatedAt { get; set; }

        ICreatedBy CreatedBy { get; set; }

        DateTime LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

    }
}
