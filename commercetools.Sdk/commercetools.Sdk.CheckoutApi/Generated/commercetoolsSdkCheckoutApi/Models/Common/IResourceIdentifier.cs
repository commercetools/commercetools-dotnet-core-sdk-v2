using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Common
{
    [TypeDiscriminator(nameof(TypeId))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.CheckoutApi.Models.Common.ResourceIdentifier))]
    [SubTypeDiscriminator("application", typeof(commercetools.Sdk.CheckoutApi.Models.Applications.ApplicationResourceIdentifier))]
    [SubTypeDiscriminator("cart", typeof(commercetools.Sdk.CheckoutApi.Models.Carts.CartResourceIdentifier))]
    [SubTypeDiscriminator("order", typeof(commercetools.Sdk.CheckoutApi.Models.Orders.OrderResourceIdentifier))]
    [SubTypeDiscriminator("payment", typeof(commercetools.Sdk.CheckoutApi.Models.Payments.PaymentResourceIdentifier))]
    [SubTypeDiscriminator("payment-integration", typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.PaymentIntegrationResourceIdentifier))]
    public partial interface IResourceIdentifier
    {
        IReferenceTypeId TypeId { get; set; }

        string Id { get; set; }

        string Key { get; set; }

        static commercetools.Sdk.CheckoutApi.Models.Applications.ApplicationResourceIdentifier Application(Action<commercetools.Sdk.CheckoutApi.Models.Applications.ApplicationResourceIdentifier> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Applications.ApplicationResourceIdentifier();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Carts.CartResourceIdentifier Cart(Action<commercetools.Sdk.CheckoutApi.Models.Carts.CartResourceIdentifier> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Carts.CartResourceIdentifier();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Orders.OrderResourceIdentifier Order(Action<commercetools.Sdk.CheckoutApi.Models.Orders.OrderResourceIdentifier> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Orders.OrderResourceIdentifier();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Payments.PaymentResourceIdentifier Payment(Action<commercetools.Sdk.CheckoutApi.Models.Payments.PaymentResourceIdentifier> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Payments.PaymentResourceIdentifier();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.PaymentIntegrationResourceIdentifier PaymentIntegration(Action<commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.PaymentIntegrationResourceIdentifier> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.PaymentIntegrationResourceIdentifier();
            init?.Invoke(t);
            return t;
        }
    }
}
