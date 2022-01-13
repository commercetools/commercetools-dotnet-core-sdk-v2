using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Payments
{
    public partial class PaymentSetAmountRefundedAction : IPaymentSetAmountRefundedAction
    {
        public string Action { get; set; }

        public IMoney Amount { get; set; }
        public PaymentSetAmountRefundedAction()
        {
            this.Action = "setAmountRefunded";
        }
    }
}
