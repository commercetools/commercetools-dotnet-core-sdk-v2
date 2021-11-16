using System;


namespace commercetools.Api.Models.Payments
{
    public partial class PaymentSetCustomFieldAction : IPaymentSetCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public PaymentSetCustomFieldAction()
        {
            this.Action = "setCustomField";
        }
    }
}
