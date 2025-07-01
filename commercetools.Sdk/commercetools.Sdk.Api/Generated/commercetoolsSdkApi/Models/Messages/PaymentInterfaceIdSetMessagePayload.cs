

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class PaymentInterfaceIdSetMessagePayload : IPaymentInterfaceIdSetMessagePayload
    {
        public string Type { get; set; }

        public string InterfaceId { get; set; }

        public string OldInterfaceId { get; set; }
        public PaymentInterfaceIdSetMessagePayload()
        {
            this.Type = "PaymentInterfaceIdSet";
        }
    }
}
