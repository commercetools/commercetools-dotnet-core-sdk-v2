using commercetools.Sdk.Api.Models.ApprovalFlows;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ApprovalFlowCreatedMessagePayload : IApprovalFlowCreatedMessagePayload
    {
        public string Type { get; set; }

        public IApprovalFlow ApprovalFlow { get; set; }
        public ApprovalFlowCreatedMessagePayload()
        {
            this.Type = "ApprovalFlowCreated";
        }
    }
}
