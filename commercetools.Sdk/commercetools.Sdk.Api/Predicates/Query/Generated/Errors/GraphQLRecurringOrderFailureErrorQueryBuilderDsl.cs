// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLRecurringOrderFailureErrorQueryBuilderDsl
    {
        public GraphQLRecurringOrderFailureErrorQueryBuilderDsl()
        {
        }

        public static GraphQLRecurringOrderFailureErrorQueryBuilderDsl Of()
        {
            return new GraphQLRecurringOrderFailureErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLRecurringOrderFailureErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLRecurringOrderFailureErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLRecurringOrderFailureErrorQueryBuilderDsl>(p, GraphQLRecurringOrderFailureErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLRecurringOrderFailureErrorQueryBuilderDsl, string> Details()
        {
            return new ComparisonPredicateBuilder<GraphQLRecurringOrderFailureErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("details")),
            p => new CombinationQueryPredicate<GraphQLRecurringOrderFailureErrorQueryBuilderDsl>(p, GraphQLRecurringOrderFailureErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
