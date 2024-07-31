

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ApprovalRuleNameSetMessagePayload : IApprovalRuleNameSetMessagePayload
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public string OldName { get; set; }
        public ApprovalRuleNameSetMessagePayload()
        {
            this.Type = "ApprovalRuleNameSet";
        }
    }
}
