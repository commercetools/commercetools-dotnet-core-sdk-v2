// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLMaxDiscountGroupsReachedErrorQueryBuilderDsl
    {
        public GraphQLMaxDiscountGroupsReachedErrorQueryBuilderDsl()
        {
        }

        public static GraphQLMaxDiscountGroupsReachedErrorQueryBuilderDsl Of()
        {
            return new GraphQLMaxDiscountGroupsReachedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLMaxDiscountGroupsReachedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLMaxDiscountGroupsReachedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLMaxDiscountGroupsReachedErrorQueryBuilderDsl>(p, GraphQLMaxDiscountGroupsReachedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
