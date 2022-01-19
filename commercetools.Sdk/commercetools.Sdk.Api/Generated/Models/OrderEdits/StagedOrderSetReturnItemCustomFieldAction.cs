using System;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetReturnItemCustomFieldAction : IStagedOrderSetReturnItemCustomFieldAction
    {
        public string Action { get; set; }

        public string ReturnItemId { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public StagedOrderSetReturnItemCustomFieldAction()
        {
            this.Action = "setReturnItemCustomField";
        }
    }
}
