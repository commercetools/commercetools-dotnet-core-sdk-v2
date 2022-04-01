using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Payments
{
    public partial class PaymentChangeAmountPlannedAction : IPaymentChangeAmountPlannedAction
    {
        public string Action { get; set; }

        public IMoney Amount { get; set; }
        public PaymentChangeAmountPlannedAction()
        {
            this.Action = "changeAmountPlanned";
        }
    }
}
