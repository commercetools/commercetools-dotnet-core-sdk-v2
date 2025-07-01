

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class PaymentMethodInfoInterfaceAccountSetMessagePayload : IPaymentMethodInfoInterfaceAccountSetMessagePayload
    {
        public string Type { get; set; }

        public string InterfaceAccount { get; set; }

        public string OldInterfaceAccount { get; set; }
        public PaymentMethodInfoInterfaceAccountSetMessagePayload()
        {
            this.Type = "PaymentMethodInfoInterfaceAccountSet";
        }
    }
}
