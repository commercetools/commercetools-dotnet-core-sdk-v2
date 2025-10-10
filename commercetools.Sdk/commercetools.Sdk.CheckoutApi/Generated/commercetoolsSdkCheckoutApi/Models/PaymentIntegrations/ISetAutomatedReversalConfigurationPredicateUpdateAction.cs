using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetAutomatedReversalConfigurationPredicateUpdateAction))]
    public partial interface ISetAutomatedReversalConfigurationPredicateUpdateAction : IPaymentIntegrationUpdateAction
    {
        string Predicate { get; set; }

    }
}
