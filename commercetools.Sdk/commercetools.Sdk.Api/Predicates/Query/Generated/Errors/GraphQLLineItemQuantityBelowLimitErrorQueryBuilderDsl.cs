// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLLineItemQuantityBelowLimitErrorQueryBuilderDsl
    {
        public GraphQLLineItemQuantityBelowLimitErrorQueryBuilderDsl()
        {
        }

        public static GraphQLLineItemQuantityBelowLimitErrorQueryBuilderDsl Of()
        {
            return new GraphQLLineItemQuantityBelowLimitErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLLineItemQuantityBelowLimitErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLLineItemQuantityBelowLimitErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLLineItemQuantityBelowLimitErrorQueryBuilderDsl>(p, GraphQLLineItemQuantityBelowLimitErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLLineItemQuantityBelowLimitErrorQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<GraphQLLineItemQuantityBelowLimitErrorQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<GraphQLLineItemQuantityBelowLimitErrorQueryBuilderDsl>(p, GraphQLLineItemQuantityBelowLimitErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLLineItemQuantityBelowLimitErrorQueryBuilderDsl, long> MinCartQuantity()
        {
            return new ComparisonPredicateBuilder<GraphQLLineItemQuantityBelowLimitErrorQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("minCartQuantity")),
            p => new CombinationQueryPredicate<GraphQLLineItemQuantityBelowLimitErrorQueryBuilderDsl>(p, GraphQLLineItemQuantityBelowLimitErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLLineItemQuantityBelowLimitErrorQueryBuilderDsl, string> LineItem()
        {
            return new ComparisonPredicateBuilder<GraphQLLineItemQuantityBelowLimitErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItem")),
            p => new CombinationQueryPredicate<GraphQLLineItemQuantityBelowLimitErrorQueryBuilderDsl>(p, GraphQLLineItemQuantityBelowLimitErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
