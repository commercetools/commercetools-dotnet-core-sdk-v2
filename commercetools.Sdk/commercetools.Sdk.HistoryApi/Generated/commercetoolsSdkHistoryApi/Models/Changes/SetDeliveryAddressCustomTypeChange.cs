using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetDeliveryAddressCustomTypeChange : ISetDeliveryAddressCustomTypeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string DeliveryId { get; set; }

        public string AddressId { get; set; }

        public ICustomFields PreviousValue { get; set; }

        public ICustomFields NextValue { get; set; }
        public SetDeliveryAddressCustomTypeChange()
        {
            this.Type = "SetDeliveryAddressCustomTypeChange";
        }
    }
}
