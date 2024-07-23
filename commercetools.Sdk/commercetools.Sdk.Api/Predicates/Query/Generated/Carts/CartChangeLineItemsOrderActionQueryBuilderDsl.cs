// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartChangeLineItemsOrderActionQueryBuilderDsl
    {
        public CartChangeLineItemsOrderActionQueryBuilderDsl()
        {
        }

        public static CartChangeLineItemsOrderActionQueryBuilderDsl Of()
        {
            return new CartChangeLineItemsOrderActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartChangeLineItemsOrderActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartChangeLineItemsOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartChangeLineItemsOrderActionQueryBuilderDsl>(p, CartChangeLineItemsOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<CartChangeLineItemsOrderActionQueryBuilderDsl, string> LineItemOrder()
        {
            return new ComparableCollectionPredicateBuilder<CartChangeLineItemsOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemOrder")),
            p => new CombinationQueryPredicate<CartChangeLineItemsOrderActionQueryBuilderDsl>(p, CartChangeLineItemsOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
