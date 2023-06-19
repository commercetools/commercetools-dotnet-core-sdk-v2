// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShoppingLists
{

    public partial class ShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl
    {
        public ShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl()
        {
        }

        public static ShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl Of()
        {
            return new ShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl>(p, ShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl, string> TextLineItemId()
        {
            return new ComparisonPredicateBuilder<ShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("textLineItemId")),
            p => new CombinationQueryPredicate<ShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl>(p, ShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl>(p, ShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<ShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<ShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl>(p, ShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
