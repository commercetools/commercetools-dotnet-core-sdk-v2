using System;

namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyPaymentSetMethodInfoCustomFieldAction : IMyPaymentSetMethodInfoCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public MyPaymentSetMethodInfoCustomFieldAction()
        {
            this.Action = "setMethodInfoCustomField";
        }
    }
}
