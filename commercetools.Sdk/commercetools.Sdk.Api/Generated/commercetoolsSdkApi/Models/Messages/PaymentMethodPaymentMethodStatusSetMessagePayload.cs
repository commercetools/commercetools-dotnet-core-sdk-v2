using commercetools.Sdk.Api.Models.PaymentMethods;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class PaymentMethodPaymentMethodStatusSetMessagePayload : IPaymentMethodPaymentMethodStatusSetMessagePayload
    {
        public string Type { get; set; }

        public IPaymentMethodStatus Status { get; set; }

        public IPaymentMethodStatus OldStatus { get; set; }
        public PaymentMethodPaymentMethodStatusSetMessagePayload()
        {
            this.Type = "PaymentMethodPaymentMethodStatusSet";
        }
    }
}
