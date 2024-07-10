using commercetools.Sdk.Api.Models.ApprovalRules;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ApprovalRuleCreatedMessagePayload : IApprovalRuleCreatedMessagePayload
    {
        public string Type { get; set; }

        public IApprovalRule ApprovalRule { get; set; }
        public ApprovalRuleCreatedMessagePayload()
        {
            this.Type = "ApprovalRuleCreated";
        }
    }
}
