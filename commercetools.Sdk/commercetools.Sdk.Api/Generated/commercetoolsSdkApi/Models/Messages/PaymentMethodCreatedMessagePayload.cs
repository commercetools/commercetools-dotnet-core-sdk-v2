using commercetools.Sdk.Api.Models.PaymentMethods;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class PaymentMethodCreatedMessagePayload : IPaymentMethodCreatedMessagePayload
    {
        public string Type { get; set; }

        public IPaymentMethod PaymentMethod { get; set; }
        public PaymentMethodCreatedMessagePayload()
        {
            this.Type = "PaymentMethodCreated";
        }
    }
}
