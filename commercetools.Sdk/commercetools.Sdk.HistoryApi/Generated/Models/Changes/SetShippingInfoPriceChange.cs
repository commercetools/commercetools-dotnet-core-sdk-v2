using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetShippingInfoPriceChange : ISetShippingInfoPriceChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IMoney NextValue { get; set; }

        public IMoney PreviousValue { get; set; }
        public SetShippingInfoPriceChange()
        {
            this.Type = "SetShippingInfoPriceChange";
        }
    }
}
