using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentChangeTransactionInteractionIdAction))]
    public partial interface IPaymentChangeTransactionInteractionIdAction : IPaymentUpdateAction
    {
        string TransactionId { get; set; }

        string InteractionId { get; set; }

    }
}
