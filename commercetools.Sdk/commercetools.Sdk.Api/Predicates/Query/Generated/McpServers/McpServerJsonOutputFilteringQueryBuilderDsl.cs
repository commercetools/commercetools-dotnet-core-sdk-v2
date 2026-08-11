using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.McpServers
{

    public partial class McpServerJsonOutputFilteringQueryBuilderDsl
    {
        public McpServerJsonOutputFilteringQueryBuilderDsl()
        {
        }

        public static McpServerJsonOutputFilteringQueryBuilderDsl Of()
        {
            return new McpServerJsonOutputFilteringQueryBuilderDsl();
        }

        public CombinationQueryPredicate<McpServerJsonOutputFilteringQueryBuilderDsl> Redact(
            Func<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerJsonOutputFilteringMatcherQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerJsonOutputFilteringMatcherQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<McpServerJsonOutputFilteringQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("redact"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerJsonOutputFilteringMatcherQueryBuilderDsl.Of())),
                McpServerJsonOutputFilteringQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<McpServerJsonOutputFilteringQueryBuilderDsl> Drop(
            Func<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerJsonOutputFilteringMatcherQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerJsonOutputFilteringMatcherQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<McpServerJsonOutputFilteringQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("drop"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerJsonOutputFilteringMatcherQueryBuilderDsl.Of())),
                McpServerJsonOutputFilteringQueryBuilderDsl.Of);
        }

        public IComparableCollectionPredicateBuilder<McpServerJsonOutputFilteringQueryBuilderDsl, string> FieldPathsToKeep()
        {
            return new ComparableCollectionPredicateBuilder<McpServerJsonOutputFilteringQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fieldPathsToKeep")),
            p => new CombinationQueryPredicate<McpServerJsonOutputFilteringQueryBuilderDsl>(p, McpServerJsonOutputFilteringQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<McpServerJsonOutputFilteringQueryBuilderDsl, string> RedactedWith()
        {
            return new ComparisonPredicateBuilder<McpServerJsonOutputFilteringQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("redactedWith")),
            p => new CombinationQueryPredicate<McpServerJsonOutputFilteringQueryBuilderDsl>(p, McpServerJsonOutputFilteringQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
