using commercetools.Sdk.Api.Models.Payments;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class OrderPaymentAddedMessagePayload : IOrderPaymentAddedMessagePayload
    {
        public string Type { get; set; }

        public IPaymentReference PaymentRef { get; set; }
        public OrderPaymentAddedMessagePayload()
        {
            this.Type = "OrderPaymentAdded";
        }
    }
}
