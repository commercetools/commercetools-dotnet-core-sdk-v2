using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetUnitTypeChange : ISetUnitTypeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IBusinessUnitResourceIdentifier ParentUnit { get; set; }

        public IBusinessUnitType PreviousValue { get; set; }

        public IBusinessUnitType NextValue { get; set; }
        public SetUnitTypeChange()
        {
            this.Type = "SetUnitTypeChange";
        }
    }
}
