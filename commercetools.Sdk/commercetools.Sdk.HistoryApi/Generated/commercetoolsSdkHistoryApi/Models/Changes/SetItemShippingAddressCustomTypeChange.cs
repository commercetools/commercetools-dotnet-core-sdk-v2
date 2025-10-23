using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetItemShippingAddressCustomTypeChange : ISetItemShippingAddressCustomTypeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string AddressId { get; set; }

        public ICustomFields PreviousValue { get; set; }

        public ICustomFields NextValue { get; set; }
        public SetItemShippingAddressCustomTypeChange()
        {
            this.Type = "SetItemShippingAddressCustomTypeChange";
        }
    }
}
