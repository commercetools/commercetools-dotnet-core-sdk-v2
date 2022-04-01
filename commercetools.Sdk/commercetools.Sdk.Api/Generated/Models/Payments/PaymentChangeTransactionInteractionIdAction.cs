namespace commercetools.Sdk.Api.Models.Payments
{
    public partial class PaymentChangeTransactionInteractionIdAction : IPaymentChangeTransactionInteractionIdAction
    {
        public string Action { get; set; }

        public string TransactionId { get; set; }

        public string InteractionId { get; set; }
        public PaymentChangeTransactionInteractionIdAction()
        {
            this.Action = "changeTransactionInteractionId";
        }
    }
}
