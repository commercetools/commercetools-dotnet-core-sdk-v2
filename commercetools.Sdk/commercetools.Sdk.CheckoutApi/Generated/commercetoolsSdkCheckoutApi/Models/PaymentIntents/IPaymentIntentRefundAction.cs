using commercetools.Sdk.CheckoutApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntents
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.PaymentIntents.PaymentIntentRefundAction))]
    public partial interface IPaymentIntentRefundAction : IPaymentIntentAction
    {
        IAmount Amount { get; set; }

        string TransactionId { get; set; }

        string MerchantReference { get; set; }

    }
}
