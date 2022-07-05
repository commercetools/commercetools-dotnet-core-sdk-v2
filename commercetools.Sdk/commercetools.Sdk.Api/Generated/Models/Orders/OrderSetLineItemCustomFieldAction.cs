using System;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSetLineItemCustomFieldAction : IOrderSetLineItemCustomFieldAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public OrderSetLineItemCustomFieldAction()
        {
            this.Action = "setLineItemCustomField";
        }
    }
}
