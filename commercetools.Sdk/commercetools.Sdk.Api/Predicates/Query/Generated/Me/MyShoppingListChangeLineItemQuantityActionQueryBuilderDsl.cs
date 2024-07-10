using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyShoppingListChangeLineItemQuantityActionQueryBuilderDsl
    {
        public MyShoppingListChangeLineItemQuantityActionQueryBuilderDsl()
        {
        }

        public static MyShoppingListChangeLineItemQuantityActionQueryBuilderDsl Of()
        {
            return new MyShoppingListChangeLineItemQuantityActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyShoppingListChangeLineItemQuantityActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyShoppingListChangeLineItemQuantityActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyShoppingListChangeLineItemQuantityActionQueryBuilderDsl>(p, MyShoppingListChangeLineItemQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyShoppingListChangeLineItemQuantityActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<MyShoppingListChangeLineItemQuantityActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<MyShoppingListChangeLineItemQuantityActionQueryBuilderDsl>(p, MyShoppingListChangeLineItemQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyShoppingListChangeLineItemQuantityActionQueryBuilderDsl, string> LineItemKey()
        {
            return new ComparisonPredicateBuilder<MyShoppingListChangeLineItemQuantityActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemKey")),
            p => new CombinationQueryPredicate<MyShoppingListChangeLineItemQuantityActionQueryBuilderDsl>(p, MyShoppingListChangeLineItemQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyShoppingListChangeLineItemQuantityActionQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<MyShoppingListChangeLineItemQuantityActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<MyShoppingListChangeLineItemQuantityActionQueryBuilderDsl>(p, MyShoppingListChangeLineItemQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
