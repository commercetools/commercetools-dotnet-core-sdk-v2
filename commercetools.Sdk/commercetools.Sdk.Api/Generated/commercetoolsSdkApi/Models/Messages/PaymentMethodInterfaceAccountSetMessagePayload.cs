

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class PaymentMethodInterfaceAccountSetMessagePayload : IPaymentMethodInterfaceAccountSetMessagePayload
    {
        public string Type { get; set; }

        public string InterfaceAccount { get; set; }

        public string OldInterfaceAccount { get; set; }
        public PaymentMethodInterfaceAccountSetMessagePayload()
        {
            this.Type = "PaymentMethodInterfaceAccountSet";
        }
    }
}
