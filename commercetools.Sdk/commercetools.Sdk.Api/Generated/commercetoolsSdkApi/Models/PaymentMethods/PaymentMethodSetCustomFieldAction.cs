using System;

namespace commercetools.Sdk.Api.Models.PaymentMethods
{

    public partial class PaymentMethodSetCustomFieldAction : IPaymentMethodSetCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public PaymentMethodSetCustomFieldAction()
        {
            this.Action = "setCustomField";
        }
    }
}
