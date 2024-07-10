using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ApprovalFlows
{

    public partial class ApprovalFlowApproveActionQueryBuilderDsl
    {
        public ApprovalFlowApproveActionQueryBuilderDsl()
        {
        }

        public static ApprovalFlowApproveActionQueryBuilderDsl Of()
        {
            return new ApprovalFlowApproveActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApprovalFlowApproveActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ApprovalFlowApproveActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ApprovalFlowApproveActionQueryBuilderDsl>(p, ApprovalFlowApproveActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
