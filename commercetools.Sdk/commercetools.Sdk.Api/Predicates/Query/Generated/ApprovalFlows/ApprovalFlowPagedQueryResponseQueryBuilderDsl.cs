using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ApprovalFlows
{

    public partial class ApprovalFlowPagedQueryResponseQueryBuilderDsl
    {
        public ApprovalFlowPagedQueryResponseQueryBuilderDsl()
        {
        }

        public static ApprovalFlowPagedQueryResponseQueryBuilderDsl Of()
        {
            return new ApprovalFlowPagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApprovalFlowPagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<ApprovalFlowPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<ApprovalFlowPagedQueryResponseQueryBuilderDsl>(p, ApprovalFlowPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalFlowPagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<ApprovalFlowPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<ApprovalFlowPagedQueryResponseQueryBuilderDsl>(p, ApprovalFlowPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalFlowPagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<ApprovalFlowPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<ApprovalFlowPagedQueryResponseQueryBuilderDsl>(p, ApprovalFlowPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApprovalFlowPagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<ApprovalFlowPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<ApprovalFlowPagedQueryResponseQueryBuilderDsl>(p, ApprovalFlowPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ApprovalFlowPagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.ApprovalFlows.ApprovalFlowQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApprovalFlows.ApprovalFlowQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApprovalFlowPagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApprovalFlows.ApprovalFlowQueryBuilderDsl.Of())),
                ApprovalFlowPagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ApprovalFlowPagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<ApprovalFlowPagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<ApprovalFlowPagedQueryResponseQueryBuilderDsl>(p, ApprovalFlowPagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
