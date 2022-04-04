using System;


namespace commercetools.Sdk.Api.Models.Orders
{
    public partial class OrderSetItemShippingAddressCustomFieldAction : IOrderSetItemShippingAddressCustomFieldAction
    {
        public string Action { get; set; }

        public string AddressKey { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public OrderSetItemShippingAddressCustomFieldAction()
        {
            this.Action = "setItemShippingAddressCustomField";
        }
    }
}
