using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntents
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntents.PaymentIntentCancelAction))]
    public partial interface IPaymentIntentCancelAction : IPaymentIntentAction
    {
        string MerchantReference { get; set; }

    }
}
