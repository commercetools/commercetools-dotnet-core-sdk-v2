using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl
    {
        public MyShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl()
        {
        }

        public static MyShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl Of()
        {
            return new MyShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl>(p, MyShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl, string> TextLineItemId()
        {
            return new ComparisonPredicateBuilder<MyShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("textLineItemId")),
            p => new CombinationQueryPredicate<MyShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl>(p, MyShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl, string> TextLineItemKey()
        {
            return new ComparisonPredicateBuilder<MyShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("textLineItemKey")),
            p => new CombinationQueryPredicate<MyShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl>(p, MyShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<MyShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<MyShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl>(p, MyShoppingListChangeTextLineItemQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
