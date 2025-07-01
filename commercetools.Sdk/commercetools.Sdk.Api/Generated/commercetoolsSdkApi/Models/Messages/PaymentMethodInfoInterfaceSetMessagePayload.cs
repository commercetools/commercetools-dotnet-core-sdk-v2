

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class PaymentMethodInfoInterfaceSetMessagePayload : IPaymentMethodInfoInterfaceSetMessagePayload
    {
        public string Type { get; set; }

        public string Interface { get; set; }

        public string OldInterface { get; set; }
        public PaymentMethodInfoInterfaceSetMessagePayload()
        {
            this.Type = "PaymentMethodInfoInterfaceSet";
        }
    }
}
