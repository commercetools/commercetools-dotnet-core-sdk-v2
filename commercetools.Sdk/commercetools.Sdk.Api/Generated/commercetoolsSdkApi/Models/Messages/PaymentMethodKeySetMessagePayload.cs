

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class PaymentMethodKeySetMessagePayload : IPaymentMethodKeySetMessagePayload
    {
        public string Type { get; set; }

        public string Key { get; set; }

        public string OldKey { get; set; }
        public PaymentMethodKeySetMessagePayload()
        {
            this.Type = "PaymentMethodKeySet";
        }
    }
}
