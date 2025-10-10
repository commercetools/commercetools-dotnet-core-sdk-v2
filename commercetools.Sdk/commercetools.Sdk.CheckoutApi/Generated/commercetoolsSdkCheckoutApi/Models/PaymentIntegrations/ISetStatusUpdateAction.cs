using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.SetStatusUpdateAction))]
    public partial interface ISetStatusUpdateAction : IPaymentIntegrationUpdateAction
    {
        IPaymentIntegrationStatus Status { get; set; }

    }
}
