

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class PaymentTransactionInterfaceIdSetMessagePayload : IPaymentTransactionInterfaceIdSetMessagePayload
    {
        public string Type { get; set; }

        public string TransactionId { get; set; }

        public string NewInterfaceId { get; set; }

        public string OldInterfaceId { get; set; }
        public PaymentTransactionInterfaceIdSetMessagePayload()
        {
            this.Type = "PaymentTransactionInterfaceIdSet";
        }
    }
}
