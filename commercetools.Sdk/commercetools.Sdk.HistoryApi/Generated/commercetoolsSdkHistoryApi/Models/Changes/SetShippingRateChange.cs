using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetShippingRateChange : ISetShippingRateChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IShippingRate PreviousValue { get; set; }

        public IShippingRate NextValue { get; set; }
        public SetShippingRateChange()
        {
            this.Type = "SetShippingRateChange";
        }
    }
}
