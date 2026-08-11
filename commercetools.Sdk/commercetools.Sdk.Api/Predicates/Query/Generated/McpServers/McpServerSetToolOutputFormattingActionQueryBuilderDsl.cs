// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.McpServers
{

    public partial class McpServerSetToolOutputFormattingActionQueryBuilderDsl
    {
        public McpServerSetToolOutputFormattingActionQueryBuilderDsl()
        {
        }

        public static McpServerSetToolOutputFormattingActionQueryBuilderDsl Of()
        {
            return new McpServerSetToolOutputFormattingActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<McpServerSetToolOutputFormattingActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<McpServerSetToolOutputFormattingActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<McpServerSetToolOutputFormattingActionQueryBuilderDsl>(p, McpServerSetToolOutputFormattingActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<McpServerSetToolOutputFormattingActionQueryBuilderDsl, string> ToolOutputFormatting()
        {
            return new ComparisonPredicateBuilder<McpServerSetToolOutputFormattingActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("toolOutputFormatting")),
            p => new CombinationQueryPredicate<McpServerSetToolOutputFormattingActionQueryBuilderDsl>(p, McpServerSetToolOutputFormattingActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
