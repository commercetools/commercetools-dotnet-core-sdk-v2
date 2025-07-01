

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class PaymentMethodCustomTypeRemovedMessagePayload : IPaymentMethodCustomTypeRemovedMessagePayload
    {
        public string Type { get; set; }

        public string OldTypeId { get; set; }
        public PaymentMethodCustomTypeRemovedMessagePayload()
        {
            this.Type = "PaymentMethodCustomTypeRemoved";
        }
    }
}
