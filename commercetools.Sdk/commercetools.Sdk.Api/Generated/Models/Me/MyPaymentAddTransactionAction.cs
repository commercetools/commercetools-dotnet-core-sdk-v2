using commercetools.Api.Models.Payments;


namespace commercetools.Api.Models.Me
{
    public partial class MyPaymentAddTransactionAction : IMyPaymentAddTransactionAction
    {
        public string Action { get; set; }

        public ITransactionDraft Transaction { get; set; }
        public MyPaymentAddTransactionAction()
        {
            this.Action = "addTransaction";
        }
    }
}
