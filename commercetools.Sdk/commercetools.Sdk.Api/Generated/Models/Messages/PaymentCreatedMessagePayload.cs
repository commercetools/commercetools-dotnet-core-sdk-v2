using commercetools.Sdk.Api.Models.Payments;


namespace commercetools.Sdk.Api.Models.Messages
{
    public partial class PaymentCreatedMessagePayload : IPaymentCreatedMessagePayload
    {
        public string Type { get; set; }

        public IPayment Payment { get; set; }
        public PaymentCreatedMessagePayload()
        {
            this.Type = "PaymentCreated";
        }
    }
}
