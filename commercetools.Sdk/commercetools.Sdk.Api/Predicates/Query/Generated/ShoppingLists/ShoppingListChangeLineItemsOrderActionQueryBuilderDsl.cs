// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShoppingLists
{

    public partial class ShoppingListChangeLineItemsOrderActionQueryBuilderDsl
    {
        public ShoppingListChangeLineItemsOrderActionQueryBuilderDsl()
        {
        }

        public static ShoppingListChangeLineItemsOrderActionQueryBuilderDsl Of()
        {
            return new ShoppingListChangeLineItemsOrderActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShoppingListChangeLineItemsOrderActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShoppingListChangeLineItemsOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShoppingListChangeLineItemsOrderActionQueryBuilderDsl>(p, ShoppingListChangeLineItemsOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<ShoppingListChangeLineItemsOrderActionQueryBuilderDsl, string> LineItemOrder()
        {
            return new ComparableCollectionPredicateBuilder<ShoppingListChangeLineItemsOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemOrder")),
            p => new CombinationQueryPredicate<ShoppingListChangeLineItemsOrderActionQueryBuilderDsl>(p, ShoppingListChangeLineItemsOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
