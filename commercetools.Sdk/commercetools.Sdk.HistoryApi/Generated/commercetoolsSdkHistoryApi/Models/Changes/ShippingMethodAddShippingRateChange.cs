using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ShippingMethodAddShippingRateChange : IShippingMethodAddShippingRateChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IZoneResourceIdentifier Zone { get; set; }

        public IShippingRate NextValue { get; set; }
        public ShippingMethodAddShippingRateChange()
        {
            this.Type = "ShippingMethodAddShippingRateChange";
        }
    }
}
