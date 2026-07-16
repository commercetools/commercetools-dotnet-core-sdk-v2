// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.McpServers
{

    public partial class McpServerSetStateActionQueryBuilderDsl
    {
        public McpServerSetStateActionQueryBuilderDsl()
        {
        }

        public static McpServerSetStateActionQueryBuilderDsl Of()
        {
            return new McpServerSetStateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<McpServerSetStateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<McpServerSetStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<McpServerSetStateActionQueryBuilderDsl>(p, McpServerSetStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<McpServerSetStateActionQueryBuilderDsl, string> State()
        {
            return new ComparisonPredicateBuilder<McpServerSetStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("state")),
            p => new CombinationQueryPredicate<McpServerSetStateActionQueryBuilderDsl>(p, McpServerSetStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
