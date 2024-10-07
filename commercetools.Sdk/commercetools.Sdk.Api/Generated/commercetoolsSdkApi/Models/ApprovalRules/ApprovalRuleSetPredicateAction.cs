

namespace commercetools.Sdk.Api.Models.ApprovalRules
{

    public partial class ApprovalRuleSetPredicateAction : IApprovalRuleSetPredicateAction
    {
        public string Action { get; set; }

        public string Predicate { get; set; }
        public ApprovalRuleSetPredicateAction()
        {
            this.Action = "setPredicate";
        }
    }
}
