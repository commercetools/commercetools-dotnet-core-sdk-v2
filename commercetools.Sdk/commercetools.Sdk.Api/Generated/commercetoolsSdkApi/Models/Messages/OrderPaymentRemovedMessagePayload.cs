using commercetools.Sdk.Api.Models.Payments;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class OrderPaymentRemovedMessagePayload : IOrderPaymentRemovedMessagePayload
    {
        public string Type { get; set; }

        public IPaymentReference PaymentRef { get; set; }

        public bool RemovedPaymentInfo { get; set; }
        public OrderPaymentRemovedMessagePayload()
        {
            this.Type = "OrderPaymentRemoved";
        }
    }
}
