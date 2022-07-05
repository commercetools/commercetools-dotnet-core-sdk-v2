using System;


namespace commercetools.Sdk.Api.Models.Payments
{

    public partial class PaymentChangeTransactionTimestampAction : IPaymentChangeTransactionTimestampAction
    {
        public string Action { get; set; }

        public string TransactionId { get; set; }

        public DateTime Timestamp { get; set; }
        public PaymentChangeTransactionTimestampAction()
        {
            this.Action = "changeTransactionTimestamp";
        }
    }
}
