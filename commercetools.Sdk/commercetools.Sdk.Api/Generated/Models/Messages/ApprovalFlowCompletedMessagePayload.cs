using commercetools.Sdk.Api.Models.ApprovalFlows;
using commercetools.Sdk.Api.Models.Orders;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ApprovalFlowCompletedMessagePayload : IApprovalFlowCompletedMessagePayload
    {
        public string Type { get; set; }

        public IApprovalFlowStatus Status { get; set; }

        public IOrderReference Order { get; set; }
        public ApprovalFlowCompletedMessagePayload()
        {
            this.Type = "ApprovalFlowCompleted";
        }
    }
}
