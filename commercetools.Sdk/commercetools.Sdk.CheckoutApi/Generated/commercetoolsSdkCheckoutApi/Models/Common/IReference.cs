using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Common
{
    [TypeDiscriminator(nameof(TypeId))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.CheckoutApi.Models.Common.Reference))]
    [SubTypeDiscriminator("application", typeof(commercetools.Sdk.CheckoutApi.Models.Applications.ApplicationReference))]
    [SubTypeDiscriminator("cart", typeof(commercetools.Sdk.CheckoutApi.Models.Carts.CartReference))]
    [SubTypeDiscriminator("order", typeof(commercetools.Sdk.CheckoutApi.Models.Carts.OrderReference))]
    [SubTypeDiscriminator("payment", typeof(commercetools.Sdk.CheckoutApi.Models.Payments.PaymentReference))]
    [SubTypeDiscriminator("payment-integration", typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.PaymentIntegrationReference))]
    [SubTypeDiscriminator("payment-method", typeof(commercetools.Sdk.CheckoutApi.Models.Common.PaymentMethodReference))]
    [SubTypeDiscriminator("recurring-order", typeof(commercetools.Sdk.CheckoutApi.Models.RecurringPayments.RecurringOrderReference))]
    [SubTypeDiscriminator("recurring-payment", typeof(commercetools.Sdk.CheckoutApi.Models.RecurringPayments.RecurringPaymentReference))]
    public partial interface IReference
    {
        IReferenceTypeId TypeId { get; set; }

        string Id { get; set; }

        static commercetools.Sdk.CheckoutApi.Models.Applications.ApplicationReference Application(Action<commercetools.Sdk.CheckoutApi.Models.Applications.ApplicationReference> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Applications.ApplicationReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Carts.CartReference Cart(Action<commercetools.Sdk.CheckoutApi.Models.Carts.CartReference> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Carts.CartReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Carts.OrderReference Order(Action<commercetools.Sdk.CheckoutApi.Models.Carts.OrderReference> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Carts.OrderReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Payments.PaymentReference Payment(Action<commercetools.Sdk.CheckoutApi.Models.Payments.PaymentReference> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Payments.PaymentReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.PaymentIntegrationReference PaymentIntegration(Action<commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.PaymentIntegrationReference> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.PaymentIntegrationReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Common.PaymentMethodReference PaymentMethod(Action<commercetools.Sdk.CheckoutApi.Models.Common.PaymentMethodReference> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Common.PaymentMethodReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.RecurringPayments.RecurringOrderReference RecurringOrder(Action<commercetools.Sdk.CheckoutApi.Models.RecurringPayments.RecurringOrderReference> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.RecurringPayments.RecurringOrderReference();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.RecurringPayments.RecurringPaymentReference RecurringPayment(Action<commercetools.Sdk.CheckoutApi.Models.RecurringPayments.RecurringPaymentReference> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.RecurringPayments.RecurringPaymentReference();
            init?.Invoke(t);
            return t;
        }
    }
}
