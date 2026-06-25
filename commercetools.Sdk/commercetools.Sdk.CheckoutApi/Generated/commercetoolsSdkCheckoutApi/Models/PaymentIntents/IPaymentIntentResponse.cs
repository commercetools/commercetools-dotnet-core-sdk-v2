using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntents
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntents.PaymentIntentResponse))]
    public partial interface IPaymentIntentResponse
    {
        IPaymentIntentOutcome Outcome { get; set; }

    }
}
