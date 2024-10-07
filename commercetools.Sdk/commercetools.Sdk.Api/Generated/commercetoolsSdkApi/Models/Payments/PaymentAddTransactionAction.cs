

namespace commercetools.Sdk.Api.Models.Payments
{

    public partial class PaymentAddTransactionAction : IPaymentAddTransactionAction
    {
        public string Action { get; set; }

        public ITransactionDraft Transaction { get; set; }
        public PaymentAddTransactionAction()
        {
            this.Action = "addTransaction";
        }
    }
}
