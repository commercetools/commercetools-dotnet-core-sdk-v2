using commercetools.Sdk.Api.Models.ApprovalRules;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ApprovalRuleStatusSetMessagePayload : IApprovalRuleStatusSetMessagePayload
    {
        public string Type { get; set; }

        public IApprovalRuleStatus Status { get; set; }

        public IApprovalRuleStatus OldStatus { get; set; }
        public ApprovalRuleStatusSetMessagePayload()
        {
            this.Type = "ApprovalRuleStatusSet";
        }
    }
}
