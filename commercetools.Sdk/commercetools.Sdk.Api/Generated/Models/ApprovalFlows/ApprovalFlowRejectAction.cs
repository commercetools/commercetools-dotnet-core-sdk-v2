namespace commercetools.Sdk.Api.Models.ApprovalFlows
{

    public partial class ApprovalFlowRejectAction : IApprovalFlowRejectAction
    {
        public string Action { get; set; }

        public string Reason { get; set; }
        public ApprovalFlowRejectAction()
        {
            this.Action = "reject";
        }
    }
}
