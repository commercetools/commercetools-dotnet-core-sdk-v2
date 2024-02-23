using System;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyPaymentSetCustomFieldAction : IMyPaymentSetCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public MyPaymentSetCustomFieldAction()
        {
            this.Action = "setCustomField";
        }
    }
}
