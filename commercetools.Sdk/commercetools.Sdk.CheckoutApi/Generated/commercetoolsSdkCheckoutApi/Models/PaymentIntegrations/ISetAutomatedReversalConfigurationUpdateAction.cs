using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetAutomatedReversalConfigurationUpdateAction))]
    public partial interface ISetAutomatedReversalConfigurationUpdateAction : IPaymentIntegrationUpdateAction
    {
        IAutomatedReversalConfiguration AutomatedReversalConfiguration { get; set; }

    }
}
