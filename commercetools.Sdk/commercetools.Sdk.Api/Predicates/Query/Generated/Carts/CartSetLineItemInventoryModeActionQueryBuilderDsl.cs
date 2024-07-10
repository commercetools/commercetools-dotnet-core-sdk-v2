using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartSetLineItemInventoryModeActionQueryBuilderDsl
    {
        public CartSetLineItemInventoryModeActionQueryBuilderDsl()
        {
        }

        public static CartSetLineItemInventoryModeActionQueryBuilderDsl Of()
        {
            return new CartSetLineItemInventoryModeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartSetLineItemInventoryModeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartSetLineItemInventoryModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartSetLineItemInventoryModeActionQueryBuilderDsl>(p, CartSetLineItemInventoryModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetLineItemInventoryModeActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<CartSetLineItemInventoryModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<CartSetLineItemInventoryModeActionQueryBuilderDsl>(p, CartSetLineItemInventoryModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetLineItemInventoryModeActionQueryBuilderDsl, string> LineItemKey()
        {
            return new ComparisonPredicateBuilder<CartSetLineItemInventoryModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemKey")),
            p => new CombinationQueryPredicate<CartSetLineItemInventoryModeActionQueryBuilderDsl>(p, CartSetLineItemInventoryModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetLineItemInventoryModeActionQueryBuilderDsl, string> InventoryMode()
        {
            return new ComparisonPredicateBuilder<CartSetLineItemInventoryModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("inventoryMode")),
            p => new CombinationQueryPredicate<CartSetLineItemInventoryModeActionQueryBuilderDsl>(p, CartSetLineItemInventoryModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
