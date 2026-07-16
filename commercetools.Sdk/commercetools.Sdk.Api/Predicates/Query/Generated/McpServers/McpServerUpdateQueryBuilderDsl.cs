using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.McpServers
{

    public partial class McpServerUpdateQueryBuilderDsl
    {
        public McpServerUpdateQueryBuilderDsl()
        {
        }

        public static McpServerUpdateQueryBuilderDsl Of()
        {
            return new McpServerUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<McpServerUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<McpServerUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<McpServerUpdateQueryBuilderDsl>(p, McpServerUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<McpServerUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<McpServerUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerUpdateActionQueryBuilderDsl.Of())),
                McpServerUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<McpServerUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<McpServerUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<McpServerUpdateQueryBuilderDsl>(p, McpServerUpdateQueryBuilderDsl.Of));
        }

    }
}
