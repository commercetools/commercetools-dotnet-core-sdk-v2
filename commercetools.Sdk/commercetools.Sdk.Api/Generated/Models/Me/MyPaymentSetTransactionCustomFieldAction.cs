using System;


namespace commercetools.Api.Models.Me
{
    public partial class MyPaymentSetTransactionCustomFieldAction : IMyPaymentSetTransactionCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public MyPaymentSetTransactionCustomFieldAction()
        {
            this.Action = "setTransactionCustomField";
        }
    }
}
