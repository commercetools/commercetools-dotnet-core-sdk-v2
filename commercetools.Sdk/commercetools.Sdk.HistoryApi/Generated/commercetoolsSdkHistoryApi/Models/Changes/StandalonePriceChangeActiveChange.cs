

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class StandalonePriceChangeActiveChange : IStandalonePriceChangeActiveChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public bool PreviousValue { get; set; }

        public bool NextValue { get; set; }
        public StandalonePriceChangeActiveChange()
        {
            this.Type = "StandalonePriceChangeActiveChange";
        }
    }
}
