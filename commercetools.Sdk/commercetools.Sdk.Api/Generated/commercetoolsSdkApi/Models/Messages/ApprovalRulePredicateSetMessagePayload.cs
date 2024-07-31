

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ApprovalRulePredicateSetMessagePayload : IApprovalRulePredicateSetMessagePayload
    {
        public string Type { get; set; }

        public string Predicate { get; set; }

        public string OldPredicate { get; set; }
        public ApprovalRulePredicateSetMessagePayload()
        {
            this.Type = "ApprovalRulePredicateSet";
        }
    }
}
