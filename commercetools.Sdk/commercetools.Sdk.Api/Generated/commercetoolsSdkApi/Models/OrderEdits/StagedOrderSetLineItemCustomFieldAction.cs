using System;

namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetLineItemCustomFieldAction : IStagedOrderSetLineItemCustomFieldAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public string LineItemKey { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public StagedOrderSetLineItemCustomFieldAction()
        {
            this.Action = "setLineItemCustomField";
        }
    }
}
