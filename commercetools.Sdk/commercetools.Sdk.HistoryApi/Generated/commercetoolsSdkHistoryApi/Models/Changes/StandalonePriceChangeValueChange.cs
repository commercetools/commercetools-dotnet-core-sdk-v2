using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class StandalonePriceChangeValueChange : IStandalonePriceChangeValueChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public bool Staged { get; set; }

        public IMoney PreviousValue { get; set; }

        public IMoney NextValue { get; set; }
        public StandalonePriceChangeValueChange()
        {
            this.Type = "StandalonePriceChangeValueChange";
        }
    }
}
