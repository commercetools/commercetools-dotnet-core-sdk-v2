using System;

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class PaymentMethodInfoCustomFieldChangedMessagePayload : IPaymentMethodInfoCustomFieldChangedMessagePayload
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public PaymentMethodInfoCustomFieldChangedMessagePayload()
        {
            this.Type = "PaymentMethodInfoCustomFieldChanged";
        }
    }
}
