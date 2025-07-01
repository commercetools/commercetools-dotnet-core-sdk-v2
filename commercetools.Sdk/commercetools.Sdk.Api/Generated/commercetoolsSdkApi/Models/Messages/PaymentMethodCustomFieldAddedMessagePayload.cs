using System;

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class PaymentMethodCustomFieldAddedMessagePayload : IPaymentMethodCustomFieldAddedMessagePayload
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public PaymentMethodCustomFieldAddedMessagePayload()
        {
            this.Type = "PaymentMethodCustomFieldAdded";
        }
    }
}
