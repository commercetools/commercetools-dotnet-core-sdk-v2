using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ApprovalFlows
{

    public partial class ApprovalFlowUpdateQueryBuilderDsl
    {
        public ApprovalFlowUpdateQueryBuilderDsl()
        {
        }

        public static ApprovalFlowUpdateQueryBuilderDsl Of()
        {
            return new ApprovalFlowUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApprovalFlowUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ApprovalFlowUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ApprovalFlowUpdateQueryBuilderDsl>(p, ApprovalFlowUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ApprovalFlowUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalFlows.ApprovalFlowUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalFlows.ApprovalFlowUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalFlowUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalFlows.ApprovalFlowUpdateActionQueryBuilderDsl.Of())),
                ApprovalFlowUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ApprovalFlowUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<ApprovalFlowUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<ApprovalFlowUpdateQueryBuilderDsl>(p, ApprovalFlowUpdateQueryBuilderDsl.Of));
        }

    }
}
