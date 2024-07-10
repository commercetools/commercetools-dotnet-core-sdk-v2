// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShoppingLists
{

    public partial class ShoppingListChangeLineItemQuantityActionQueryBuilderDsl
    {
        public ShoppingListChangeLineItemQuantityActionQueryBuilderDsl()
        {
        }

        public static ShoppingListChangeLineItemQuantityActionQueryBuilderDsl Of()
        {
            return new ShoppingListChangeLineItemQuantityActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShoppingListChangeLineItemQuantityActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShoppingListChangeLineItemQuantityActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShoppingListChangeLineItemQuantityActionQueryBuilderDsl>(p, ShoppingListChangeLineItemQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListChangeLineItemQuantityActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<ShoppingListChangeLineItemQuantityActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<ShoppingListChangeLineItemQuantityActionQueryBuilderDsl>(p, ShoppingListChangeLineItemQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListChangeLineItemQuantityActionQueryBuilderDsl, string> LineItemKey()
        {
            return new ComparisonPredicateBuilder<ShoppingListChangeLineItemQuantityActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemKey")),
            p => new CombinationQueryPredicate<ShoppingListChangeLineItemQuantityActionQueryBuilderDsl>(p, ShoppingListChangeLineItemQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListChangeLineItemQuantityActionQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<ShoppingListChangeLineItemQuantityActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<ShoppingListChangeLineItemQuantityActionQueryBuilderDsl>(p, ShoppingListChangeLineItemQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
