using System;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    public partial class StagedOrderSetItemShippingAddressCustomFieldAction : IStagedOrderSetItemShippingAddressCustomFieldAction
    {
        public string Action { get; set; }

        public string AddressKey { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public StagedOrderSetItemShippingAddressCustomFieldAction()
        {
            this.Action = "setItemShippingAddressCustomField";
        }
    }
}
