// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLInvalidInputErrorQueryBuilderDsl
    {
        public GraphQLInvalidInputErrorQueryBuilderDsl()
        {
        }

        public static GraphQLInvalidInputErrorQueryBuilderDsl Of()
        {
            return new GraphQLInvalidInputErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLInvalidInputErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLInvalidInputErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLInvalidInputErrorQueryBuilderDsl>(p, GraphQLInvalidInputErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
