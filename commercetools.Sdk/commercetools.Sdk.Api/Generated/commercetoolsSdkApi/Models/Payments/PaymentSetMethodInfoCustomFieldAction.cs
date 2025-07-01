using System;

namespace commercetools.Sdk.Api.Models.Payments
{

    public partial class PaymentSetMethodInfoCustomFieldAction : IPaymentSetMethodInfoCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public PaymentSetMethodInfoCustomFieldAction()
        {
            this.Action = "setMethodInfoCustomField";
        }
    }
}
