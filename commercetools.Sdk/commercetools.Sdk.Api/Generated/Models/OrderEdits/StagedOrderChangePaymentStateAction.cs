using commercetools.Sdk.Api.Models.Orders;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    public partial class StagedOrderChangePaymentStateAction : IStagedOrderChangePaymentStateAction
    {
        public string Action { get; set; }

        public IPaymentState PaymentState { get; set; }
        public StagedOrderChangePaymentStateAction()
        {
            this.Action = "changePaymentState";
        }
    }
}
