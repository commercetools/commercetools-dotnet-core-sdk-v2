// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ApprovalRules
{

    public partial class ApprovalRuleSetPredicateActionQueryBuilderDsl
    {
        public ApprovalRuleSetPredicateActionQueryBuilderDsl()
        {
        }

        public static ApprovalRuleSetPredicateActionQueryBuilderDsl Of()
        {
            return new ApprovalRuleSetPredicateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApprovalRuleSetPredicateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleSetPredicateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ApprovalRuleSetPredicateActionQueryBuilderDsl>(p, ApprovalRuleSetPredicateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRuleSetPredicateActionQueryBuilderDsl, string> Predicate()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleSetPredicateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("predicate")),
            p => new CombinationQueryPredicate<ApprovalRuleSetPredicateActionQueryBuilderDsl>(p, ApprovalRuleSetPredicateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
