using commercetools.Sdk.Api.Models.Payments;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentTransactionStateChangedMessagePayload))]
    public partial interface IPaymentTransactionStateChangedMessagePayload : IMessagePayload
    {
        string TransactionId { get; set; }

        ITransactionState State { get; set; }
    }
}
