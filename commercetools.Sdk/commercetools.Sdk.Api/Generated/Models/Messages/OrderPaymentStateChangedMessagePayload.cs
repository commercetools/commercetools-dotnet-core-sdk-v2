using commercetools.Api.Models.Orders;


namespace commercetools.Api.Models.Messages
{
    public partial class OrderPaymentStateChangedMessagePayload : IOrderPaymentStateChangedMessagePayload
    {
        public string Type { get; set; }

        public IPaymentState PaymentState { get; set; }

        public IPaymentState OldPaymentState { get; set; }
        public OrderPaymentStateChangedMessagePayload()
        {
            this.Type = "OrderPaymentStateChanged";
        }
    }
}
