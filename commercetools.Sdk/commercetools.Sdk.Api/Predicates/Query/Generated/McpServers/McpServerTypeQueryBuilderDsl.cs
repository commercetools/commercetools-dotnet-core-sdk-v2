using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.McpServers
{

    public partial class McpServerTypeQueryBuilderDsl
    {
        public McpServerTypeQueryBuilderDsl()
        {
        }

        public static McpServerTypeQueryBuilderDsl Of()
        {
            return new McpServerTypeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<McpServerTypeQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<McpServerTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<McpServerTypeQueryBuilderDsl>(p, McpServerTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<McpServerTypeQueryBuilderDsl, string> MajorVersion()
        {
            return new ComparisonPredicateBuilder<McpServerTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("majorVersion")),
            p => new CombinationQueryPredicate<McpServerTypeQueryBuilderDsl>(p, McpServerTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<McpServerTypeQueryBuilderDsl> Tools(
            Func<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerTypeToolQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerTypeToolQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<McpServerTypeQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("tools"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.McpServers.McpServerTypeToolQueryBuilderDsl.Of())),
                McpServerTypeQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<McpServerTypeQueryBuilderDsl> Tools()
        {
            return new CollectionPredicateBuilder<McpServerTypeQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("tools")),
                    p => new CombinationQueryPredicate<McpServerTypeQueryBuilderDsl>(p, McpServerTypeQueryBuilderDsl.Of));
        }

    }
}
