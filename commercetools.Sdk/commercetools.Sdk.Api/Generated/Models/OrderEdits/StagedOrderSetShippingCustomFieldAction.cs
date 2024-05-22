using System;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetShippingCustomFieldAction : IStagedOrderSetShippingCustomFieldAction
    {
        public string Action { get; set; }

        public string ShippingKey { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public StagedOrderSetShippingCustomFieldAction()
        {
            this.Action = "setShippingCustomField";
        }
    }
}
