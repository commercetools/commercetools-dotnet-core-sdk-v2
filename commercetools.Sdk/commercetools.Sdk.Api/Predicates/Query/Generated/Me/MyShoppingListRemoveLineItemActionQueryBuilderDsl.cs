using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyShoppingListRemoveLineItemActionQueryBuilderDsl
    {
        public MyShoppingListRemoveLineItemActionQueryBuilderDsl()
        {
        }

        public static MyShoppingListRemoveLineItemActionQueryBuilderDsl Of()
        {
            return new MyShoppingListRemoveLineItemActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyShoppingListRemoveLineItemActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyShoppingListRemoveLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyShoppingListRemoveLineItemActionQueryBuilderDsl>(p, MyShoppingListRemoveLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyShoppingListRemoveLineItemActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<MyShoppingListRemoveLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<MyShoppingListRemoveLineItemActionQueryBuilderDsl>(p, MyShoppingListRemoveLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyShoppingListRemoveLineItemActionQueryBuilderDsl, string> LineItemKey()
        {
            return new ComparisonPredicateBuilder<MyShoppingListRemoveLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemKey")),
            p => new CombinationQueryPredicate<MyShoppingListRemoveLineItemActionQueryBuilderDsl>(p, MyShoppingListRemoveLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyShoppingListRemoveLineItemActionQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<MyShoppingListRemoveLineItemActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<MyShoppingListRemoveLineItemActionQueryBuilderDsl>(p, MyShoppingListRemoveLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
