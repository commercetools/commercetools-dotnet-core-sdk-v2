using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeApprovalRuleModeChange : IChangeApprovalRuleModeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IBusinessUnitApprovalRuleMode PreviousValue { get; set; }

        public IBusinessUnitApprovalRuleMode NextValue { get; set; }
        public ChangeApprovalRuleModeChange()
        {
            this.Type = "ChangeApprovalRuleModeChange";
        }
    }
}
