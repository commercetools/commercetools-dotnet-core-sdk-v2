using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentChangeTransactionInteractionIdAction))]
    public partial interface IPaymentChangeTransactionInteractionIdAction : IPaymentUpdateAction
    {
        string TransactionId { get; set; }

        string InteractionId { get; set; }

    }
}
