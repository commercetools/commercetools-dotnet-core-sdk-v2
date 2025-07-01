

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class PaymentMethodDefaultSetMessagePayload : IPaymentMethodDefaultSetMessagePayload
    {
        public string Type { get; set; }

        public bool Default { get; set; }

        public bool OldDefault { get; set; }
        public PaymentMethodDefaultSetMessagePayload()
        {
            this.Type = "PaymentMethodDefaultSet";
        }
    }
}
