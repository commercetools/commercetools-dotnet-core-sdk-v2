

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class PaymentMethodMethodSetMessagePayload : IPaymentMethodMethodSetMessagePayload
    {
        public string Type { get; set; }

        public string Method { get; set; }

        public string OldMethod { get; set; }
        public PaymentMethodMethodSetMessagePayload()
        {
            this.Type = "PaymentMethodMethodSet";
        }
    }
}
