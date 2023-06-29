using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeAssociateModeChange : IChangeAssociateModeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IBusinessUnitAssociateMode PreviousValue { get; set; }

        public IBusinessUnitAssociateMode NextValue { get; set; }
        public ChangeAssociateModeChange()
        {
            this.Type = "ChangeAssociateModeChange";
        }
    }
}
