using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ApprovalFlows
{

    public partial class ApprovalFlowApprovalQueryBuilderDsl
    {
        public ApprovalFlowApprovalQueryBuilderDsl()
        {
        }

        public static ApprovalFlowApprovalQueryBuilderDsl Of()
        {
            return new ApprovalFlowApprovalQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ApprovalFlowApprovalQueryBuilderDsl> Approver(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalFlowApprovalQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("approver"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateQueryBuilderDsl.Of())),
                ApprovalFlowApprovalQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ApprovalFlowApprovalQueryBuilderDsl, DateTime> ApprovedAt()
        {
            return new ComparisonPredicateBuilder<ApprovalFlowApprovalQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("approvedAt")),
            p => new CombinationQueryPredicate<ApprovalFlowApprovalQueryBuilderDsl>(p, ApprovalFlowApprovalQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
