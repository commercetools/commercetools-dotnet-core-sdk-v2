using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetStoreModeChange : ISetStoreModeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IBusinessUnitStoreMode PreviousValue { get; set; }

        public IBusinessUnitStoreMode NextValue { get; set; }
        public SetStoreModeChange()
        {
            this.Type = "SetStoreModeChange";
        }
    }
}
