using System;


namespace commercetools.Api.Models.Payments
{
    public partial class PaymentSetTransactionCustomFieldAction : IPaymentSetTransactionCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public PaymentSetTransactionCustomFieldAction()
        {
            this.Action = "setTransactionCustomField";
        }
    }
}
