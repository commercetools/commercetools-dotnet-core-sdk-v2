// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLNoMatchingProductDiscountFoundErrorQueryBuilderDsl
    {
        public GraphQLNoMatchingProductDiscountFoundErrorQueryBuilderDsl()
        {
        }

        public static GraphQLNoMatchingProductDiscountFoundErrorQueryBuilderDsl Of()
        {
            return new GraphQLNoMatchingProductDiscountFoundErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLNoMatchingProductDiscountFoundErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLNoMatchingProductDiscountFoundErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLNoMatchingProductDiscountFoundErrorQueryBuilderDsl>(p, GraphQLNoMatchingProductDiscountFoundErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
