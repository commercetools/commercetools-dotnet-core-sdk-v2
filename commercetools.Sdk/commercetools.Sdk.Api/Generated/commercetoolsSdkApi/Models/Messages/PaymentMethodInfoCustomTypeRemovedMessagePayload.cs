

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class PaymentMethodInfoCustomTypeRemovedMessagePayload : IPaymentMethodInfoCustomTypeRemovedMessagePayload
    {
        public string Type { get; set; }

        public string OldTypeId { get; set; }
        public PaymentMethodInfoCustomTypeRemovedMessagePayload()
        {
            this.Type = "PaymentMethodInfoCustomTypeRemoved";
        }
    }
}
