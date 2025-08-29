using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntents
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntents.PaymentIntentReverseAction))]
    public partial interface IPaymentIntentReverseAction : IPaymentIntentAction
    {
        string MerchantReference { get; set; }

    }
}
