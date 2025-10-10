using commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Applications
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Applications.PaymentsConfiguration))]
    public partial interface IPaymentsConfiguration
    {
        string PaymentReturnUrl { get; set; }

        IPaymentComponentType ActivePaymentComponentType { get; set; }

    }
}
