using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class StandalonePriceSetDiscountedPriceChange : IStandalonePriceSetDiscountedPriceChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public bool Staged { get; set; }

        public IDiscountedPrice PreviousValue { get; set; }

        public IDiscountedPrice NextValue { get; set; }
        public StandalonePriceSetDiscountedPriceChange()
        {
            this.Type = "StandalonePriceSetDiscountedPriceChange";
        }
    }
}
