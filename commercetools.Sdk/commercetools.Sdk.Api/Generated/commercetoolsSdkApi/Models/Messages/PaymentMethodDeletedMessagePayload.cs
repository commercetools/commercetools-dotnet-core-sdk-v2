using commercetools.Sdk.Api.Models.PaymentMethods;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class PaymentMethodDeletedMessagePayload : IPaymentMethodDeletedMessagePayload
    {
        public string Type { get; set; }

        public IPaymentMethod PaymentMethod { get; set; }
        public PaymentMethodDeletedMessagePayload()
        {
            this.Type = "PaymentMethodDeleted";
        }
    }
}
