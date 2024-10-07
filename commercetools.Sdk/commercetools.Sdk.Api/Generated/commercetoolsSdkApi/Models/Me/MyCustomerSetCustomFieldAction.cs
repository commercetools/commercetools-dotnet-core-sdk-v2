using System;

namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCustomerSetCustomFieldAction : IMyCustomerSetCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public MyCustomerSetCustomFieldAction()
        {
            this.Action = "setCustomField";
        }
    }
}
