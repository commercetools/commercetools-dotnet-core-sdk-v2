using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeStatusChange : IChangeStatusChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IBusinessUnitStatus PreviousValue { get; set; }

        public IBusinessUnitStatus NextValue { get; set; }
        public ChangeStatusChange()
        {
            this.Type = "ChangeStatusChange";
        }
    }
}
