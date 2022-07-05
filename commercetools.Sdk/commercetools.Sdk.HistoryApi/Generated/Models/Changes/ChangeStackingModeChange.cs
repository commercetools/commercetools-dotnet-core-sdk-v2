using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeStackingModeChange : IChangeStackingModeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IStackingMode NextValue { get; set; }

        public IStackingMode PreviousValue { get; set; }
        public ChangeStackingModeChange()
        {
            this.Type = "ChangeStackingModeChange";
        }
    }
}
