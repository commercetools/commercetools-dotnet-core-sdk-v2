using System;

namespace commercetools.Sdk.Api.Models.CustomerGroups
{

    public partial class CustomerGroupSetCustomFieldAction : ICustomerGroupSetCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public CustomerGroupSetCustomFieldAction()
        {
            this.Action = "setCustomField";
        }
    }
}
