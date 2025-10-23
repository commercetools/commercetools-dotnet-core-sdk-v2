using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangePriceRoundingModeChange : IChangePriceRoundingModeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IRoundingMode PreviousValue { get; set; }

        public IRoundingMode NextValue { get; set; }
        public ChangePriceRoundingModeChange()
        {
            this.Type = "ChangePriceRoundingModeChange";
        }
    }
}
