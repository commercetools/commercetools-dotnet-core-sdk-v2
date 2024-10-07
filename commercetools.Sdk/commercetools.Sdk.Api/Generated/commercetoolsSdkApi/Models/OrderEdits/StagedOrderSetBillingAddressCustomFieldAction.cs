using System;

namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetBillingAddressCustomFieldAction : IStagedOrderSetBillingAddressCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public StagedOrderSetBillingAddressCustomFieldAction()
        {
            this.Action = "setBillingAddressCustomField";
        }
    }
}
