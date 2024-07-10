// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShoppingLists
{

    public partial class ShoppingListSetLineItemCustomFieldActionQueryBuilderDsl
    {
        public ShoppingListSetLineItemCustomFieldActionQueryBuilderDsl()
        {
        }

        public static ShoppingListSetLineItemCustomFieldActionQueryBuilderDsl Of()
        {
            return new ShoppingListSetLineItemCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShoppingListSetLineItemCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShoppingListSetLineItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShoppingListSetLineItemCustomFieldActionQueryBuilderDsl>(p, ShoppingListSetLineItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListSetLineItemCustomFieldActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<ShoppingListSetLineItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<ShoppingListSetLineItemCustomFieldActionQueryBuilderDsl>(p, ShoppingListSetLineItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListSetLineItemCustomFieldActionQueryBuilderDsl, string> LineItemKey()
        {
            return new ComparisonPredicateBuilder<ShoppingListSetLineItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemKey")),
            p => new CombinationQueryPredicate<ShoppingListSetLineItemCustomFieldActionQueryBuilderDsl>(p, ShoppingListSetLineItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListSetLineItemCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ShoppingListSetLineItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ShoppingListSetLineItemCustomFieldActionQueryBuilderDsl>(p, ShoppingListSetLineItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListSetLineItemCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<ShoppingListSetLineItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<ShoppingListSetLineItemCustomFieldActionQueryBuilderDsl>(p, ShoppingListSetLineItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
