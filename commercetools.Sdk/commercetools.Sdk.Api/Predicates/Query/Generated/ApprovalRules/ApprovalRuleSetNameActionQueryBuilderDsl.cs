// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ApprovalRules
{

    public partial class ApprovalRuleSetNameActionQueryBuilderDsl
    {
        public ApprovalRuleSetNameActionQueryBuilderDsl()
        {
        }

        public static ApprovalRuleSetNameActionQueryBuilderDsl Of()
        {
            return new ApprovalRuleSetNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApprovalRuleSetNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleSetNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ApprovalRuleSetNameActionQueryBuilderDsl>(p, ApprovalRuleSetNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRuleSetNameActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleSetNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ApprovalRuleSetNameActionQueryBuilderDsl>(p, ApprovalRuleSetNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
