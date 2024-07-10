// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyShoppingListSetLineItemCustomFieldActionQueryBuilderDsl
    {
        public MyShoppingListSetLineItemCustomFieldActionQueryBuilderDsl()
        {
        }

        public static MyShoppingListSetLineItemCustomFieldActionQueryBuilderDsl Of()
        {
            return new MyShoppingListSetLineItemCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyShoppingListSetLineItemCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyShoppingListSetLineItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyShoppingListSetLineItemCustomFieldActionQueryBuilderDsl>(p, MyShoppingListSetLineItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyShoppingListSetLineItemCustomFieldActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<MyShoppingListSetLineItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<MyShoppingListSetLineItemCustomFieldActionQueryBuilderDsl>(p, MyShoppingListSetLineItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyShoppingListSetLineItemCustomFieldActionQueryBuilderDsl, string> LineItemKey()
        {
            return new ComparisonPredicateBuilder<MyShoppingListSetLineItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemKey")),
            p => new CombinationQueryPredicate<MyShoppingListSetLineItemCustomFieldActionQueryBuilderDsl>(p, MyShoppingListSetLineItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyShoppingListSetLineItemCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<MyShoppingListSetLineItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<MyShoppingListSetLineItemCustomFieldActionQueryBuilderDsl>(p, MyShoppingListSetLineItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyShoppingListSetLineItemCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<MyShoppingListSetLineItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<MyShoppingListSetLineItemCustomFieldActionQueryBuilderDsl>(p, MyShoppingListSetLineItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
