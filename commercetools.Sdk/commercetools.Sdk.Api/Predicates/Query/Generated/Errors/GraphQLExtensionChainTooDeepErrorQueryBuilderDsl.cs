// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLExtensionChainTooDeepErrorQueryBuilderDsl
    {
        public GraphQLExtensionChainTooDeepErrorQueryBuilderDsl()
        {
        }

        public static GraphQLExtensionChainTooDeepErrorQueryBuilderDsl Of()
        {
            return new GraphQLExtensionChainTooDeepErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLExtensionChainTooDeepErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLExtensionChainTooDeepErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLExtensionChainTooDeepErrorQueryBuilderDsl>(p, GraphQLExtensionChainTooDeepErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
