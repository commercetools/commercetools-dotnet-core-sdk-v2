using commercetools.Sdk.CheckoutApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntents
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntents.PaymentIntentCaptureAction))]
    public partial interface IPaymentIntentCaptureAction : IPaymentIntentAction
    {
        IAmount Amount { get; set; }

        string MerchantReference { get; set; }

    }
}
