// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.McpServers
{

    public partial class McpServerSetAuthenticationModeActionQueryBuilderDsl
    {
        public McpServerSetAuthenticationModeActionQueryBuilderDsl()
        {
        }

        public static McpServerSetAuthenticationModeActionQueryBuilderDsl Of()
        {
            return new McpServerSetAuthenticationModeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<McpServerSetAuthenticationModeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<McpServerSetAuthenticationModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<McpServerSetAuthenticationModeActionQueryBuilderDsl>(p, McpServerSetAuthenticationModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<McpServerSetAuthenticationModeActionQueryBuilderDsl, string> AuthenticationMode()
        {
            return new ComparisonPredicateBuilder<McpServerSetAuthenticationModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("authenticationMode")),
            p => new CombinationQueryPredicate<McpServerSetAuthenticationModeActionQueryBuilderDsl>(p, McpServerSetAuthenticationModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
