

namespace commercetools.Sdk.Api.Models.ApprovalRules
{

    public partial class ApprovalRuleSetStatusAction : IApprovalRuleSetStatusAction
    {
        public string Action { get; set; }

        public IApprovalRuleStatus Status { get; set; }
        public ApprovalRuleSetStatusAction()
        {
            this.Action = "setStatus";
        }
    }
}
