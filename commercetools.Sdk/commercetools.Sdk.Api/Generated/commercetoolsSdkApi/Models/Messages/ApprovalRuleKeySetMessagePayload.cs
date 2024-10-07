

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ApprovalRuleKeySetMessagePayload : IApprovalRuleKeySetMessagePayload
    {
        public string Type { get; set; }

        public string Key { get; set; }

        public string OldKey { get; set; }
        public ApprovalRuleKeySetMessagePayload()
        {
            this.Type = "ApprovalRuleKeySet";
        }
    }
}
