using System;


namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerSetAddressCustomFieldAction : ICustomerSetAddressCustomFieldAction
    {
        public string Action { get; set; }

        public string AddressId { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public CustomerSetAddressCustomFieldAction()
        {
            this.Action = "setAddressCustomField";
        }
    }
}
