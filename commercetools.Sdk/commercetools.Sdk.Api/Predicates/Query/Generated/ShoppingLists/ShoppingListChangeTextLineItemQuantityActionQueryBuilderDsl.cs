// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShoppingLists
{

    public partial class ShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl
    {
        public ShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl()
        {
        }

        public static ShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl Of()
        {
            return new ShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl>(p, ShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl, string> TextLineItemId()
        {
            return new ComparisonPredicateBuilder<ShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("textLineItemId")),
            p => new CombinationQueryPredicate<ShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl>(p, ShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl, string> TextLineItemKey()
        {
            return new ComparisonPredicateBuilder<ShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("textLineItemKey")),
            p => new CombinationQueryPredicate<ShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl>(p, ShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<ShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<ShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl>(p, ShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
