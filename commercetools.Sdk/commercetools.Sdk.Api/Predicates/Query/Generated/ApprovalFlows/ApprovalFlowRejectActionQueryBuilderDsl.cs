// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ApprovalFlows
{

    public partial class ApprovalFlowRejectActionQueryBuilderDsl
    {
        public ApprovalFlowRejectActionQueryBuilderDsl()
        {
        }

        public static ApprovalFlowRejectActionQueryBuilderDsl Of()
        {
            return new ApprovalFlowRejectActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApprovalFlowRejectActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ApprovalFlowRejectActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ApprovalFlowRejectActionQueryBuilderDsl>(p, ApprovalFlowRejectActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalFlowRejectActionQueryBuilderDsl, string> Reason()
        {
            return new ComparisonPredicateBuilder<ApprovalFlowRejectActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("reason")),
            p => new CombinationQueryPredicate<ApprovalFlowRejectActionQueryBuilderDsl>(p, ApprovalFlowRejectActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
