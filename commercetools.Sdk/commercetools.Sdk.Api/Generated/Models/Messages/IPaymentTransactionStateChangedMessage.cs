using commercetools.Api.Models.Payments;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.PaymentTransactionStateChangedMessage))]
    public partial interface IPaymentTransactionStateChangedMessage : IMessage
    {
        string TransactionId { get; set; }

        ITransactionState State { get; set; }
    }
}
