using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.AutomatedReversalConfiguration))]
    public partial interface IAutomatedReversalConfiguration
    {
        string Status { get; set; }

        string Predicate { get; set; }

    }
}
