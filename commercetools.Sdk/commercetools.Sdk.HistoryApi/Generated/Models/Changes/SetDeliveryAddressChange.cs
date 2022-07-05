using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetDeliveryAddressChange : ISetDeliveryAddressChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string DeliveryId { get; set; }

        public IAddress NextValue { get; set; }

        public IAddress PreviousValue { get; set; }
        public SetDeliveryAddressChange()
        {
            this.Type = "SetDeliveryAddressChange";
        }
    }
}
