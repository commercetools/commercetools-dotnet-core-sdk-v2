using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntents
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntents.PaymentIntentAction))]
    [SubTypeDiscriminator("cancelPayment", typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntents.PaymentIntentCancelAction))]
    [SubTypeDiscriminator("capturePayment", typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntents.PaymentIntentCaptureAction))]
    [SubTypeDiscriminator("refundPayment", typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntents.PaymentIntentRefundAction))]
    [SubTypeDiscriminator("reversePayment", typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntents.PaymentIntentReverseAction))]
    public partial interface IPaymentIntentAction
    {
        IPaymentIntentOperation Action { get; set; }

        static commercetools.Sdk.CheckoutApi.Models.PaymentIntents.PaymentIntentCancelAction CancelPayment(Action<commercetools.Sdk.CheckoutApi.Models.PaymentIntents.PaymentIntentCancelAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.PaymentIntents.PaymentIntentCancelAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.PaymentIntents.PaymentIntentCaptureAction CapturePayment(Action<commercetools.Sdk.CheckoutApi.Models.PaymentIntents.PaymentIntentCaptureAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.PaymentIntents.PaymentIntentCaptureAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.PaymentIntents.PaymentIntentRefundAction RefundPayment(Action<commercetools.Sdk.CheckoutApi.Models.PaymentIntents.PaymentIntentRefundAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.PaymentIntents.PaymentIntentRefundAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.PaymentIntents.PaymentIntentReverseAction ReversePayment(Action<commercetools.Sdk.CheckoutApi.Models.PaymentIntents.PaymentIntentReverseAction> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.PaymentIntents.PaymentIntentReverseAction();
            init?.Invoke(t);
            return t;
        }
    }
}
