// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ApprovalRules
{

    public partial class ApprovalRuleSetKeyActionQueryBuilderDsl
    {
        public ApprovalRuleSetKeyActionQueryBuilderDsl()
        {
        }

        public static ApprovalRuleSetKeyActionQueryBuilderDsl Of()
        {
            return new ApprovalRuleSetKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApprovalRuleSetKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ApprovalRuleSetKeyActionQueryBuilderDsl>(p, ApprovalRuleSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRuleSetKeyActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ApprovalRuleSetKeyActionQueryBuilderDsl>(p, ApprovalRuleSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
