using System;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetDeliveryCustomFieldChange : ISetDeliveryCustomFieldChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string DeliveryId { get; set; }

        public string Name { get; set; }

        public string CustomTypeId { get; set; }

        public Object PreviousValue { get; set; }

        public Object NextValue { get; set; }
        public SetDeliveryCustomFieldChange()
        {
            this.Type = "SetDeliveryCustomFieldChange";
        }
    }
}
