// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShoppingLists
{

    public partial class ShoppingListRemoveLineItemActionQueryBuilderDsl
    {
        public ShoppingListRemoveLineItemActionQueryBuilderDsl()
        {
        }

        public static ShoppingListRemoveLineItemActionQueryBuilderDsl Of()
        {
            return new ShoppingListRemoveLineItemActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShoppingListRemoveLineItemActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShoppingListRemoveLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShoppingListRemoveLineItemActionQueryBuilderDsl>(p, ShoppingListRemoveLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListRemoveLineItemActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<ShoppingListRemoveLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<ShoppingListRemoveLineItemActionQueryBuilderDsl>(p, ShoppingListRemoveLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListRemoveLineItemActionQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<ShoppingListRemoveLineItemActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<ShoppingListRemoveLineItemActionQueryBuilderDsl>(p, ShoppingListRemoveLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
