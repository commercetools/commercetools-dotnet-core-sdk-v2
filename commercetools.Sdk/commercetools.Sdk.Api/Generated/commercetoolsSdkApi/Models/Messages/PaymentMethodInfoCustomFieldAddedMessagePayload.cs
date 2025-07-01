using System;

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class PaymentMethodInfoCustomFieldAddedMessagePayload : IPaymentMethodInfoCustomFieldAddedMessagePayload
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public PaymentMethodInfoCustomFieldAddedMessagePayload()
        {
            this.Type = "PaymentMethodInfoCustomFieldAdded";
        }
    }
}
