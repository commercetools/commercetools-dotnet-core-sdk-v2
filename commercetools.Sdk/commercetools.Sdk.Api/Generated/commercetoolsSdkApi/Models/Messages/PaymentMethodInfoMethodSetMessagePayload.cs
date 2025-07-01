

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class PaymentMethodInfoMethodSetMessagePayload : IPaymentMethodInfoMethodSetMessagePayload
    {
        public string Type { get; set; }

        public string Method { get; set; }

        public string OldMethod { get; set; }
        public PaymentMethodInfoMethodSetMessagePayload()
        {
            this.Type = "PaymentMethodInfoMethodSet";
        }
    }
}
