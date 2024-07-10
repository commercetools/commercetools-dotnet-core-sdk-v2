// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLShippingMethodDoesNotMatchCartErrorQueryBuilderDsl
    {
        public GraphQLShippingMethodDoesNotMatchCartErrorQueryBuilderDsl()
        {
        }

        public static GraphQLShippingMethodDoesNotMatchCartErrorQueryBuilderDsl Of()
        {
            return new GraphQLShippingMethodDoesNotMatchCartErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLShippingMethodDoesNotMatchCartErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLShippingMethodDoesNotMatchCartErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLShippingMethodDoesNotMatchCartErrorQueryBuilderDsl>(p, GraphQLShippingMethodDoesNotMatchCartErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
