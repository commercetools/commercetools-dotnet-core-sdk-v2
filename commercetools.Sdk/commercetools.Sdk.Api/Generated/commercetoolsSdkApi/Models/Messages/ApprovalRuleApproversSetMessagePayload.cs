using commercetools.Sdk.Api.Models.ApprovalRules;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ApprovalRuleApproversSetMessagePayload : IApprovalRuleApproversSetMessagePayload
    {
        public string Type { get; set; }

        public IApproverHierarchy Approvers { get; set; }

        public IApproverHierarchy OldApprovers { get; set; }
        public ApprovalRuleApproversSetMessagePayload()
        {
            this.Type = "ApprovalRuleApproversSet";
        }
    }
}
