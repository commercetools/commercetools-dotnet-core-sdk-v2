// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLAnonymousIdAlreadyInUseErrorQueryBuilderDsl
    {
        public GraphQLAnonymousIdAlreadyInUseErrorQueryBuilderDsl()
        {
        }

        public static GraphQLAnonymousIdAlreadyInUseErrorQueryBuilderDsl Of()
        {
            return new GraphQLAnonymousIdAlreadyInUseErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLAnonymousIdAlreadyInUseErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLAnonymousIdAlreadyInUseErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLAnonymousIdAlreadyInUseErrorQueryBuilderDsl>(p, GraphQLAnonymousIdAlreadyInUseErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
