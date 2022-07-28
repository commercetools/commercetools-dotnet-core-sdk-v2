using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentChangeTransactionStateAction))]
    public partial interface IPaymentChangeTransactionStateAction : IPaymentUpdateAction
    {
        string TransactionId { get; set; }

        ITransactionState State { get; set; }

    }
}
