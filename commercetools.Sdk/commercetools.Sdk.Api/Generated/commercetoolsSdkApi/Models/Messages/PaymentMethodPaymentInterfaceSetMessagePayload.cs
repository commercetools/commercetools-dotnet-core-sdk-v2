

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class PaymentMethodPaymentInterfaceSetMessagePayload : IPaymentMethodPaymentInterfaceSetMessagePayload
    {
        public string Type { get; set; }

        public string PaymentInterface { get; set; }

        public string OldPaymentInterface { get; set; }
        public PaymentMethodPaymentInterfaceSetMessagePayload()
        {
            this.Type = "PaymentMethodPaymentInterfaceSet";
        }
    }
}
