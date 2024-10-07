

namespace commercetools.Sdk.Api.Models.ApprovalFlows
{

    public partial class ApprovalFlowApproveAction : IApprovalFlowApproveAction
    {
        public string Action { get; set; }
        public ApprovalFlowApproveAction()
        {
            this.Action = "approve";
        }
    }
}
