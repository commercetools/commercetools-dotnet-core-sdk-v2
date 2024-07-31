

namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitChangeApprovalRuleModeAction : IBusinessUnitChangeApprovalRuleModeAction
    {
        public string Action { get; set; }

        public IBusinessUnitApprovalRuleMode ApprovalRuleMode { get; set; }
        public BusinessUnitChangeApprovalRuleModeAction()
        {
            this.Action = "changeApprovalRuleMode";
        }
    }
}
