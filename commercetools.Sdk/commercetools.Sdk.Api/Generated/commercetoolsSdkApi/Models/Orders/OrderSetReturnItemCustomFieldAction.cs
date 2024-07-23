using System;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSetReturnItemCustomFieldAction : IOrderSetReturnItemCustomFieldAction
    {
        public string Action { get; set; }

        public string ReturnItemId { get; set; }

        public string ReturnItemKey { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public OrderSetReturnItemCustomFieldAction()
        {
            this.Action = "setReturnItemCustomField";
        }
    }
}
