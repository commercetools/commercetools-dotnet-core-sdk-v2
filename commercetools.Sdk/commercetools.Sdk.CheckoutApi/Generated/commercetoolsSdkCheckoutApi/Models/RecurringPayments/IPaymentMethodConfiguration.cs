using commercetools.Sdk.CheckoutApi.Models.Common;
using commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.RecurringPayments
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.RecurringPayments.PaymentMethodConfiguration))]
    public partial interface IPaymentMethodConfiguration
    {
        IPaymentMethodReference PaymentMethod { get; set; }

        IConnectorDeploymentReference ConnectorDeployment { get; set; }

    }
}
