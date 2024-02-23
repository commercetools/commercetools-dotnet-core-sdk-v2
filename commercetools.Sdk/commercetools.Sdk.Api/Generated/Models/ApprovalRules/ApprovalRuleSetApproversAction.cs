namespace commercetools.Sdk.Api.Models.ApprovalRules
{

    public partial class ApprovalRuleSetApproversAction : IApprovalRuleSetApproversAction
    {
        public string Action { get; set; }

        public IApproverHierarchyDraft Approvers { get; set; }
        public ApprovalRuleSetApproversAction()
        {
            this.Action = "setApprovers";
        }
    }
}
