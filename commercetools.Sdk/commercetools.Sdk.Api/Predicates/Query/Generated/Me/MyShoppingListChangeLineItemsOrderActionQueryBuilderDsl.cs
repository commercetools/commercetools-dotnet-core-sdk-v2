using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyShoppingListChangeLineItemsOrderActionQueryBuilderDsl
    {
        public MyShoppingListChangeLineItemsOrderActionQueryBuilderDsl()
        {
        }

        public static MyShoppingListChangeLineItemsOrderActionQueryBuilderDsl Of()
        {
            return new MyShoppingListChangeLineItemsOrderActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyShoppingListChangeLineItemsOrderActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyShoppingListChangeLineItemsOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyShoppingListChangeLineItemsOrderActionQueryBuilderDsl>(p, MyShoppingListChangeLineItemsOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<MyShoppingListChangeLineItemsOrderActionQueryBuilderDsl, string> LineItemOrder()
        {
            return new ComparableCollectionPredicateBuilder<MyShoppingListChangeLineItemsOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemOrder")),
            p => new CombinationQueryPredicate<MyShoppingListChangeLineItemsOrderActionQueryBuilderDsl>(p, MyShoppingListChangeLineItemsOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
