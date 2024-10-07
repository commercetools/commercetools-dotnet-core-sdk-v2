using System;

namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSetShippingCustomFieldAction : IOrderSetShippingCustomFieldAction
    {
        public string Action { get; set; }

        public string ShippingKey { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public OrderSetShippingCustomFieldAction()
        {
            this.Action = "setShippingCustomField";
        }
    }
}
