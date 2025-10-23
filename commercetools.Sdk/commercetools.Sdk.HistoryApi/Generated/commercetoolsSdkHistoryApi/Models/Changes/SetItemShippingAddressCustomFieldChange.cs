using System;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetItemShippingAddressCustomFieldChange : ISetItemShippingAddressCustomFieldChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string AddressId { get; set; }

        public string Name { get; set; }

        public string CustomTypeId { get; set; }

        public Object PreviousValue { get; set; }

        public Object NextValue { get; set; }
        public SetItemShippingAddressCustomFieldChange()
        {
            this.Type = "SetItemShippingAddressCustomFieldChange";
        }
    }
}
