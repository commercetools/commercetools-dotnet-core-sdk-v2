using System;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetShippingAddressCustomFieldAction : IStagedOrderSetShippingAddressCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public StagedOrderSetShippingAddressCustomFieldAction()
        {
            this.Action = "setShippingAddressCustomField";
        }
    }
}
