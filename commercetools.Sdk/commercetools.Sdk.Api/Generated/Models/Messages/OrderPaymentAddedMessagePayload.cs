using commercetools.Api.Models.Payments;


namespace commercetools.Api.Models.Messages
{
    public partial class OrderPaymentAddedMessagePayload : IOrderPaymentAddedMessagePayload
    {
        public string Type { get; set; }

        public IPaymentReference Payment { get; set; }
        public OrderPaymentAddedMessagePayload()
        {
            this.Type = "OrderPaymentAdded";
        }
    }
}
