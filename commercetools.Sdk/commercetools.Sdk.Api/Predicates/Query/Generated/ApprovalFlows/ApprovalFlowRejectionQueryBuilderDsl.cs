using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ApprovalFlows
{

    public partial class ApprovalFlowRejectionQueryBuilderDsl
    {
        public ApprovalFlowRejectionQueryBuilderDsl()
        {
        }

        public static ApprovalFlowRejectionQueryBuilderDsl Of()
        {
            return new ApprovalFlowRejectionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ApprovalFlowRejectionQueryBuilderDsl> Rejecter(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalFlowRejectionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("rejecter"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateQueryBuilderDsl.Of())),
                ApprovalFlowRejectionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ApprovalFlowRejectionQueryBuilderDsl, DateTime> RejectedAt()
        {
            return new ComparisonPredicateBuilder<ApprovalFlowRejectionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("rejectedAt")),
            p => new CombinationQueryPredicate<ApprovalFlowRejectionQueryBuilderDsl>(p, ApprovalFlowRejectionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalFlowRejectionQueryBuilderDsl, string> Reason()
        {
            return new ComparisonPredicateBuilder<ApprovalFlowRejectionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("reason")),
            p => new CombinationQueryPredicate<ApprovalFlowRejectionQueryBuilderDsl>(p, ApprovalFlowRejectionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
