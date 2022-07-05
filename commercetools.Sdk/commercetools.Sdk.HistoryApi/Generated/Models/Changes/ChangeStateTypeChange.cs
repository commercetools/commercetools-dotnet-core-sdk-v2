using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeStateTypeChange : IChangeStateTypeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IStateType PreviousValue { get; set; }

        public IStateType NextValue { get; set; }
        public ChangeStateTypeChange()
        {
            this.Type = "ChangeStateTypeChange";
        }
    }
}
