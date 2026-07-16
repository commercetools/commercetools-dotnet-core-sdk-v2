// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.McpServers
{

    public partial class McpServerSetToolsActionQueryBuilderDsl
    {
        public McpServerSetToolsActionQueryBuilderDsl()
        {
        }

        public static McpServerSetToolsActionQueryBuilderDsl Of()
        {
            return new McpServerSetToolsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<McpServerSetToolsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<McpServerSetToolsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<McpServerSetToolsActionQueryBuilderDsl>(p, McpServerSetToolsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<McpServerSetToolsActionQueryBuilderDsl, string> Tools()
        {
            return new ComparableCollectionPredicateBuilder<McpServerSetToolsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("tools")),
            p => new CombinationQueryPredicate<McpServerSetToolsActionQueryBuilderDsl>(p, McpServerSetToolsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
