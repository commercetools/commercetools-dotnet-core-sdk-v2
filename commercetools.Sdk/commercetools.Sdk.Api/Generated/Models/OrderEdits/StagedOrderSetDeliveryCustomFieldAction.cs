using System;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetDeliveryCustomFieldAction : IStagedOrderSetDeliveryCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public StagedOrderSetDeliveryCustomFieldAction()
        {
            this.Action = "setDeliveryCustomField";
        }
    }
}
