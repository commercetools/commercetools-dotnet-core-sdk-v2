using commercetools.Sdk.CheckoutApi.Models.Common;
using commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations;


namespace commercetools.Sdk.CheckoutApi.Models.RecurringPayments
{

    public partial class PaymentMethodConfiguration : IPaymentMethodConfiguration
    {
        public IPaymentMethodReference PaymentMethod { get; set; }

        public IConnectorDeploymentReference ConnectorDeployment { get; set; }
    }
}
