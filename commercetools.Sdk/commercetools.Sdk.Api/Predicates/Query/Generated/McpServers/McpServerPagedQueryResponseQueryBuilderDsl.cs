using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.McpServers
{

    public partial class McpServerPagedQueryResponseQueryBuilderDsl
    {
        public McpServerPagedQueryResponseQueryBuilderDsl()
        {
        }

        public static McpServerPagedQueryResponseQueryBuilderDsl Of()
        {
            return new McpServerPagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<McpServerPagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<McpServerPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<McpServerPagedQueryResponseQueryBuilderDsl>(p, McpServerPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<McpServerPagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<McpServerPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<McpServerPagedQueryResponseQueryBuilderDsl>(p, McpServerPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<McpServerPagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<McpServerPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<McpServerPagedQueryResponseQueryBuilderDsl>(p, McpServerPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<McpServerPagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<McpServerPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<McpServerPagedQueryResponseQueryBuilderDsl>(p, McpServerPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<McpServerPagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<McpServerPagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerQueryBuilderDsl.Of())),
                McpServerPagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<McpServerPagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<McpServerPagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<McpServerPagedQueryResponseQueryBuilderDsl>(p, McpServerPagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
