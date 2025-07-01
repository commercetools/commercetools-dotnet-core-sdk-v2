

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class PaymentMethodInfoCustomFieldRemovedMessagePayload : IPaymentMethodInfoCustomFieldRemovedMessagePayload
    {
        public string Type { get; set; }

        public string Name { get; set; }
        public PaymentMethodInfoCustomFieldRemovedMessagePayload()
        {
            this.Type = "PaymentMethodInfoCustomFieldRemoved";
        }
    }
}
