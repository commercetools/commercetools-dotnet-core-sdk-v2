using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeAmountPlannedChange : IChangeAmountPlannedChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IMoney PreviousValue { get; set; }

        public IMoney NextValue { get; set; }
        public ChangeAmountPlannedChange()
        {
            this.Type = "ChangeAmountPlannedChange";
        }
    }
}
