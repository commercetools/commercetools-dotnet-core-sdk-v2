using commercetools.Api.Models.Payments;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.PaymentTransactionStateChangedMessagePayload))]
    public partial interface IPaymentTransactionStateChangedMessagePayload : IMessagePayload
    {
        string TransactionId { get; set; }

        ITransactionState State { get; set; }
    }
}
