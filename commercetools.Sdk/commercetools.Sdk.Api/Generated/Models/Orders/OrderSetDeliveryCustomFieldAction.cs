using System;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSetDeliveryCustomFieldAction : IOrderSetDeliveryCustomFieldAction
    {
        public string Action { get; set; }

        public string DeliveryId { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public OrderSetDeliveryCustomFieldAction()
        {
            this.Action = "setDeliveryCustomField";
        }
    }
}
