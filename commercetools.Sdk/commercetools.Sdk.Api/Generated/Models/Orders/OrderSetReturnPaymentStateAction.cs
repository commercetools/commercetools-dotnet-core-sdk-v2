namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSetReturnPaymentStateAction : IOrderSetReturnPaymentStateAction
    {
        public string Action { get; set; }

        public string ReturnItemId { get; set; }

        public string ReturnItemKey { get; set; }

        public IReturnPaymentState PaymentState { get; set; }
        public OrderSetReturnPaymentStateAction()
        {
            this.Action = "setReturnPaymentState";
        }
    }
}
