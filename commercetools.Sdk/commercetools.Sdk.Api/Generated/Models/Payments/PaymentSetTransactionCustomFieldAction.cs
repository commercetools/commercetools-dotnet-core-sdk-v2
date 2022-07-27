using System;


namespace commercetools.Sdk.Api.Models.Payments
{

    public partial class PaymentSetTransactionCustomFieldAction : IPaymentSetTransactionCustomFieldAction
    {
        public string Action { get; set; }

        public string TransactionId { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public PaymentSetTransactionCustomFieldAction()
        {
            this.Action = "setTransactionCustomField";
        }
    }
}
