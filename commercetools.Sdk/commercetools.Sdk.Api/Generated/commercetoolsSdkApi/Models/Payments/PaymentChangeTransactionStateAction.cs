

namespace commercetools.Sdk.Api.Models.Payments
{

    public partial class PaymentChangeTransactionStateAction : IPaymentChangeTransactionStateAction
    {
        public string Action { get; set; }

        public string TransactionId { get; set; }

        public ITransactionState State { get; set; }
        public PaymentChangeTransactionStateAction()
        {
            this.Action = "changeTransactionState";
        }
    }
}
