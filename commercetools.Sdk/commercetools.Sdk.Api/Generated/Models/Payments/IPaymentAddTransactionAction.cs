using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentAddTransactionAction))]
    public partial interface IPaymentAddTransactionAction : IPaymentUpdateAction
    {
        ITransactionDraft Transaction { get; set; }

    }
}
