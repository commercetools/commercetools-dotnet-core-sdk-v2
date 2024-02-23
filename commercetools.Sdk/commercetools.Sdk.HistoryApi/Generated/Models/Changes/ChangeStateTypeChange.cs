using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeStateTypeChange : IChangeStateTypeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IStateTypeEnum PreviousValue { get; set; }

        public IStateTypeEnum NextValue { get; set; }
        public ChangeStateTypeChange()
        {
            this.Type = "ChangeStateTypeChange";
        }
    }
}
