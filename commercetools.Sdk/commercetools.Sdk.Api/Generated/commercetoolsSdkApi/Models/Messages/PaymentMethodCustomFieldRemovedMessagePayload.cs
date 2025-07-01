

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class PaymentMethodCustomFieldRemovedMessagePayload : IPaymentMethodCustomFieldRemovedMessagePayload
    {
        public string Type { get; set; }

        public string Name { get; set; }
        public PaymentMethodCustomFieldRemovedMessagePayload()
        {
            this.Type = "PaymentMethodCustomFieldRemoved";
        }
    }
}
