using System;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetDeliveryAddressCustomFieldAction : IStagedOrderSetDeliveryAddressCustomFieldAction
    {
        public string Action { get; set; }

        public string DeliveryId { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public StagedOrderSetDeliveryAddressCustomFieldAction()
        {
            this.Action = "setDeliveryAddressCustomField";
        }
    }
}
