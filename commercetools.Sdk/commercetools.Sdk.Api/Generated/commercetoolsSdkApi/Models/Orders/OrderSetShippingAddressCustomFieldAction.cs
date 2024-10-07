using System;

namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSetShippingAddressCustomFieldAction : IOrderSetShippingAddressCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public OrderSetShippingAddressCustomFieldAction()
        {
            this.Action = "setShippingAddressCustomField";
        }
    }
}
