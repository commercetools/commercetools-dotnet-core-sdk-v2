using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ShippingMethodRemoveZoneChange : IShippingMethodRemoveZoneChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IReference PreviousValue { get; set; }
        public ShippingMethodRemoveZoneChange()
        {
            this.Type = "ShippingMethodRemoveZoneChange";
        }
    }
}
