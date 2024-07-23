using System;


namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerSetCustomFieldAction : ICustomerSetCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public CustomerSetCustomFieldAction()
        {
            this.Action = "setCustomField";
        }
    }
}
