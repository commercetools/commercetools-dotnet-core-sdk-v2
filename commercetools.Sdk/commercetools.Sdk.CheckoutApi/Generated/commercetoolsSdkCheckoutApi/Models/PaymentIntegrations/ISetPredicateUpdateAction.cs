using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetPredicateUpdateAction))]
    public partial interface ISetPredicateUpdateAction : IPaymentIntegrationUpdateAction
    {
        string Predicate { get; set; }

    }
}
