// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLLineItemQuantityAboveLimitErrorQueryBuilderDsl
    {
        public GraphQLLineItemQuantityAboveLimitErrorQueryBuilderDsl()
        {
        }

        public static GraphQLLineItemQuantityAboveLimitErrorQueryBuilderDsl Of()
        {
            return new GraphQLLineItemQuantityAboveLimitErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLLineItemQuantityAboveLimitErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLLineItemQuantityAboveLimitErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLLineItemQuantityAboveLimitErrorQueryBuilderDsl>(p, GraphQLLineItemQuantityAboveLimitErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLLineItemQuantityAboveLimitErrorQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<GraphQLLineItemQuantityAboveLimitErrorQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<GraphQLLineItemQuantityAboveLimitErrorQueryBuilderDsl>(p, GraphQLLineItemQuantityAboveLimitErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLLineItemQuantityAboveLimitErrorQueryBuilderDsl, long> MaxCartQuantity()
        {
            return new ComparisonPredicateBuilder<GraphQLLineItemQuantityAboveLimitErrorQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("maxCartQuantity")),
            p => new CombinationQueryPredicate<GraphQLLineItemQuantityAboveLimitErrorQueryBuilderDsl>(p, GraphQLLineItemQuantityAboveLimitErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLLineItemQuantityAboveLimitErrorQueryBuilderDsl, string> LineItem()
        {
            return new ComparisonPredicateBuilder<GraphQLLineItemQuantityAboveLimitErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItem")),
            p => new CombinationQueryPredicate<GraphQLLineItemQuantityAboveLimitErrorQueryBuilderDsl>(p, GraphQLLineItemQuantityAboveLimitErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
