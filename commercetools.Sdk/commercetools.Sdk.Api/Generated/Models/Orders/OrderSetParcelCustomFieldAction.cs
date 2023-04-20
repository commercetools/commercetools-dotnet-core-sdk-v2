using System;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSetParcelCustomFieldAction : IOrderSetParcelCustomFieldAction
    {
        public string Action { get; set; }

        public string ParcelId { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public OrderSetParcelCustomFieldAction()
        {
            this.Action = "setParcelCustomField";
        }
    }
}
