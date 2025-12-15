using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class StandalonePriceSetCustomTypeChange : IStandalonePriceSetCustomTypeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ICustomFields PreviousValue { get; set; }

        public ICustomFields NextValue { get; set; }
        public StandalonePriceSetCustomTypeChange()
        {
            this.Type = "StandalonePriceSetCustomTypeChange";
        }
    }
}
