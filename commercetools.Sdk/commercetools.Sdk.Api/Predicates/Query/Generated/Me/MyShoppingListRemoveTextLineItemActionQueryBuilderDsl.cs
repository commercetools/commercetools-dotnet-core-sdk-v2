// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyShoppingListRemoveTextLineItemActionQueryBuilderDsl
    {
        public MyShoppingListRemoveTextLineItemActionQueryBuilderDsl()
        {
        }

        public static MyShoppingListRemoveTextLineItemActionQueryBuilderDsl Of()
        {
            return new MyShoppingListRemoveTextLineItemActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyShoppingListRemoveTextLineItemActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyShoppingListRemoveTextLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyShoppingListRemoveTextLineItemActionQueryBuilderDsl>(p, MyShoppingListRemoveTextLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyShoppingListRemoveTextLineItemActionQueryBuilderDsl, string> TextLineItemId()
        {
            return new ComparisonPredicateBuilder<MyShoppingListRemoveTextLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("textLineItemId")),
            p => new CombinationQueryPredicate<MyShoppingListRemoveTextLineItemActionQueryBuilderDsl>(p, MyShoppingListRemoveTextLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyShoppingListRemoveTextLineItemActionQueryBuilderDsl, string> TextLineItemKey()
        {
            return new ComparisonPredicateBuilder<MyShoppingListRemoveTextLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("textLineItemKey")),
            p => new CombinationQueryPredicate<MyShoppingListRemoveTextLineItemActionQueryBuilderDsl>(p, MyShoppingListRemoveTextLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyShoppingListRemoveTextLineItemActionQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<MyShoppingListRemoveTextLineItemActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<MyShoppingListRemoveTextLineItemActionQueryBuilderDsl>(p, MyShoppingListRemoveTextLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
