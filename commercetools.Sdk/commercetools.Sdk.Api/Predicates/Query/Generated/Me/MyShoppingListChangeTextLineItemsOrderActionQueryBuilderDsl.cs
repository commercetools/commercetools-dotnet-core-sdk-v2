using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyShoppingListChangeTextLineItemsOrderActionQueryBuilderDsl
    {
        public MyShoppingListChangeTextLineItemsOrderActionQueryBuilderDsl()
        {
        }

        public static MyShoppingListChangeTextLineItemsOrderActionQueryBuilderDsl Of()
        {
            return new MyShoppingListChangeTextLineItemsOrderActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyShoppingListChangeTextLineItemsOrderActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyShoppingListChangeTextLineItemsOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyShoppingListChangeTextLineItemsOrderActionQueryBuilderDsl>(p, MyShoppingListChangeTextLineItemsOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<MyShoppingListChangeTextLineItemsOrderActionQueryBuilderDsl, string> TextLineItemOrder()
        {
            return new ComparableCollectionPredicateBuilder<MyShoppingListChangeTextLineItemsOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("textLineItemOrder")),
            p => new CombinationQueryPredicate<MyShoppingListChangeTextLineItemsOrderActionQueryBuilderDsl>(p, MyShoppingListChangeTextLineItemsOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
