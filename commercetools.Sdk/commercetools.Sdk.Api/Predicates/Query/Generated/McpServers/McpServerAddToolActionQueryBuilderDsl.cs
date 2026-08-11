// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.McpServers
{

    public partial class McpServerAddToolActionQueryBuilderDsl
    {
        public McpServerAddToolActionQueryBuilderDsl()
        {
        }

        public static McpServerAddToolActionQueryBuilderDsl Of()
        {
            return new McpServerAddToolActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<McpServerAddToolActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<McpServerAddToolActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<McpServerAddToolActionQueryBuilderDsl>(p, McpServerAddToolActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<McpServerAddToolActionQueryBuilderDsl, string> Tool()
        {
            return new ComparisonPredicateBuilder<McpServerAddToolActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("tool")),
            p => new CombinationQueryPredicate<McpServerAddToolActionQueryBuilderDsl>(p, McpServerAddToolActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
