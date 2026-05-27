// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLExtensionChainTooWideErrorQueryBuilderDsl
    {
        public GraphQLExtensionChainTooWideErrorQueryBuilderDsl()
        {
        }

        public static GraphQLExtensionChainTooWideErrorQueryBuilderDsl Of()
        {
            return new GraphQLExtensionChainTooWideErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLExtensionChainTooWideErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLExtensionChainTooWideErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLExtensionChainTooWideErrorQueryBuilderDsl>(p, GraphQLExtensionChainTooWideErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
