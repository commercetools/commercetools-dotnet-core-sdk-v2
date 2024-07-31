using System;

namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSetDeliveryAddressCustomFieldAction : IOrderSetDeliveryAddressCustomFieldAction
    {
        public string Action { get; set; }

        public string DeliveryId { get; set; }

        public string DeliveryKey { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public OrderSetDeliveryAddressCustomFieldAction()
        {
            this.Action = "setDeliveryAddressCustomField";
        }
    }
}
