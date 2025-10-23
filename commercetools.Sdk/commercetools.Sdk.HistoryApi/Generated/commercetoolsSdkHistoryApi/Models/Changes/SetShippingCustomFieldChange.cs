using System;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetShippingCustomFieldChange : ISetShippingCustomFieldChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string ShippingKey { get; set; }

        public string Name { get; set; }

        public string CustomTypeId { get; set; }

        public Object PreviousValue { get; set; }

        public Object NextValue { get; set; }
        public SetShippingCustomFieldChange()
        {
            this.Type = "SetShippingCustomFieldChange";
        }
    }
}
