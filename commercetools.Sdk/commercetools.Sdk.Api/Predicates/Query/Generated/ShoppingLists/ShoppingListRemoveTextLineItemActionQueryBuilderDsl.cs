// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShoppingLists
{

    public partial class ShoppingListRemoveTextLineItemActionQueryBuilderDsl
    {
        public ShoppingListRemoveTextLineItemActionQueryBuilderDsl()
        {
        }

        public static ShoppingListRemoveTextLineItemActionQueryBuilderDsl Of()
        {
            return new ShoppingListRemoveTextLineItemActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShoppingListRemoveTextLineItemActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShoppingListRemoveTextLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShoppingListRemoveTextLineItemActionQueryBuilderDsl>(p, ShoppingListRemoveTextLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListRemoveTextLineItemActionQueryBuilderDsl, string> TextLineItemId()
        {
            return new ComparisonPredicateBuilder<ShoppingListRemoveTextLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("textLineItemId")),
            p => new CombinationQueryPredicate<ShoppingListRemoveTextLineItemActionQueryBuilderDsl>(p, ShoppingListRemoveTextLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListRemoveTextLineItemActionQueryBuilderDsl, string> TextLineItemKey()
        {
            return new ComparisonPredicateBuilder<ShoppingListRemoveTextLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("textLineItemKey")),
            p => new CombinationQueryPredicate<ShoppingListRemoveTextLineItemActionQueryBuilderDsl>(p, ShoppingListRemoveTextLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListRemoveTextLineItemActionQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<ShoppingListRemoveTextLineItemActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<ShoppingListRemoveTextLineItemActionQueryBuilderDsl>(p, ShoppingListRemoveTextLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
