using commercetools.Sdk.Api.Models.Payments;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class PaymentTransactionStateChangedMessagePayload : IPaymentTransactionStateChangedMessagePayload
    {
        public string Type { get; set; }

        public string TransactionId { get; set; }

        public ITransactionState State { get; set; }
        public PaymentTransactionStateChangedMessagePayload()
        {
            this.Type = "PaymentTransactionStateChanged";
        }
    }
}
