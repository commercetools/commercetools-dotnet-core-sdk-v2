using commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations;


namespace commercetools.Sdk.CheckoutApi.Models.Applications
{

    public partial class PaymentsConfiguration : IPaymentsConfiguration
    {
        public string PaymentReturnUrl { get; set; }

        public IPaymentComponentType ActivePaymentComponentType { get; set; }
    }
}
