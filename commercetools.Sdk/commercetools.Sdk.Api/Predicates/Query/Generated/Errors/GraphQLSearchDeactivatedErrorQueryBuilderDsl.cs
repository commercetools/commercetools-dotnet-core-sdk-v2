// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLSearchDeactivatedErrorQueryBuilderDsl
    {
        public GraphQLSearchDeactivatedErrorQueryBuilderDsl()
        {
        }

        public static GraphQLSearchDeactivatedErrorQueryBuilderDsl Of()
        {
            return new GraphQLSearchDeactivatedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLSearchDeactivatedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLSearchDeactivatedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLSearchDeactivatedErrorQueryBuilderDsl>(p, GraphQLSearchDeactivatedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
