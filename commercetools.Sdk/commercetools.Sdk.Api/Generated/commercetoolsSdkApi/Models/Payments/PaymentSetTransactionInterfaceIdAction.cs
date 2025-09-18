

namespace commercetools.Sdk.Api.Models.Payments
{

    public partial class PaymentSetTransactionInterfaceIdAction : IPaymentSetTransactionInterfaceIdAction
    {
        public string Action { get; set; }

        public string TransactionId { get; set; }

        public string InterfaceId { get; set; }
        public PaymentSetTransactionInterfaceIdAction()
        {
            this.Action = "setTransactionInterfaceId";
        }
    }
}
