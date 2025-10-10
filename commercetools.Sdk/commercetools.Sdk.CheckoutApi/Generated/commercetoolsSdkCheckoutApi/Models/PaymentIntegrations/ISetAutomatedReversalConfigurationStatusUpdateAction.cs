using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetAutomatedReversalConfigurationStatusUpdateAction))]
    public partial interface ISetAutomatedReversalConfigurationStatusUpdateAction : IPaymentIntegrationUpdateAction
    {
        string Status { get; set; }

    }
}
