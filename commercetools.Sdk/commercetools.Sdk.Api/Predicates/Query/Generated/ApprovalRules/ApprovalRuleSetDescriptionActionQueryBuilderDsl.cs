// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ApprovalRules
{

    public partial class ApprovalRuleSetDescriptionActionQueryBuilderDsl
    {
        public ApprovalRuleSetDescriptionActionQueryBuilderDsl()
        {
        }

        public static ApprovalRuleSetDescriptionActionQueryBuilderDsl Of()
        {
            return new ApprovalRuleSetDescriptionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApprovalRuleSetDescriptionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleSetDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ApprovalRuleSetDescriptionActionQueryBuilderDsl>(p, ApprovalRuleSetDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalRuleSetDescriptionActionQueryBuilderDsl, string> Description()
        {
            return new ComparisonPredicateBuilder<ApprovalRuleSetDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("description")),
            p => new CombinationQueryPredicate<ApprovalRuleSetDescriptionActionQueryBuilderDsl>(p, ApprovalRuleSetDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
