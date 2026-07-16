// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.McpServers
{

    public partial class McpServerRemoveToolActionQueryBuilderDsl
    {
        public McpServerRemoveToolActionQueryBuilderDsl()
        {
        }

        public static McpServerRemoveToolActionQueryBuilderDsl Of()
        {
            return new McpServerRemoveToolActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<McpServerRemoveToolActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<McpServerRemoveToolActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<McpServerRemoveToolActionQueryBuilderDsl>(p, McpServerRemoveToolActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<McpServerRemoveToolActionQueryBuilderDsl, string> Tool()
        {
            return new ComparisonPredicateBuilder<McpServerRemoveToolActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("tool")),
            p => new CombinationQueryPredicate<McpServerRemoveToolActionQueryBuilderDsl>(p, McpServerRemoveToolActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
