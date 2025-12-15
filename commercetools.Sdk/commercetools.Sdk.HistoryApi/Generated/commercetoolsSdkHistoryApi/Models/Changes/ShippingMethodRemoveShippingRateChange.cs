using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ShippingMethodRemoveShippingRateChange : IShippingMethodRemoveShippingRateChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IZoneResourceIdentifier Zone { get; set; }

        public IShippingRate PreviousValue { get; set; }
        public ShippingMethodRemoveShippingRateChange()
        {
            this.Type = "ShippingMethodRemoveShippingRateChange";
        }
    }
}
