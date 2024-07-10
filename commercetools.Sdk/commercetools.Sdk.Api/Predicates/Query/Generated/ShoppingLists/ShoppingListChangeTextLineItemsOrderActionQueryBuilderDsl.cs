// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShoppingLists
{

    public partial class ShoppingListChangeTextLineItemsOrderActionQueryBuilderDsl
    {
        public ShoppingListChangeTextLineItemsOrderActionQueryBuilderDsl()
        {
        }

        public static ShoppingListChangeTextLineItemsOrderActionQueryBuilderDsl Of()
        {
            return new ShoppingListChangeTextLineItemsOrderActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShoppingListChangeTextLineItemsOrderActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShoppingListChangeTextLineItemsOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShoppingListChangeTextLineItemsOrderActionQueryBuilderDsl>(p, ShoppingListChangeTextLineItemsOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<ShoppingListChangeTextLineItemsOrderActionQueryBuilderDsl, string> TextLineItemOrder()
        {
            return new ComparableCollectionPredicateBuilder<ShoppingListChangeTextLineItemsOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("textLineItemOrder")),
            p => new CombinationQueryPredicate<ShoppingListChangeTextLineItemsOrderActionQueryBuilderDsl>(p, ShoppingListChangeTextLineItemsOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
