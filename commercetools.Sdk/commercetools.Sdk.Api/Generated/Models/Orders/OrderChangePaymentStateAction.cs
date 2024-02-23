namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderChangePaymentStateAction : IOrderChangePaymentStateAction
    {
        public string Action { get; set; }

        public IPaymentState PaymentState { get; set; }
        public OrderChangePaymentStateAction()
        {
            this.Action = "changePaymentState";
        }
    }
}
