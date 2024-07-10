using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartSetLineItemTotalPriceActionQueryBuilderDsl
    {
        public CartSetLineItemTotalPriceActionQueryBuilderDsl()
        {
        }

        public static CartSetLineItemTotalPriceActionQueryBuilderDsl Of()
        {
            return new CartSetLineItemTotalPriceActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartSetLineItemTotalPriceActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartSetLineItemTotalPriceActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartSetLineItemTotalPriceActionQueryBuilderDsl>(p, CartSetLineItemTotalPriceActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetLineItemTotalPriceActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<CartSetLineItemTotalPriceActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<CartSetLineItemTotalPriceActionQueryBuilderDsl>(p, CartSetLineItemTotalPriceActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetLineItemTotalPriceActionQueryBuilderDsl, string> LineItemKey()
        {
            return new ComparisonPredicateBuilder<CartSetLineItemTotalPriceActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemKey")),
            p => new CombinationQueryPredicate<CartSetLineItemTotalPriceActionQueryBuilderDsl>(p, CartSetLineItemTotalPriceActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartSetLineItemTotalPriceActionQueryBuilderDsl> ExternalTotalPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalLineItemTotalPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalLineItemTotalPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartSetLineItemTotalPriceActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalTotalPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ExternalLineItemTotalPriceQueryBuilderDsl.Of())),
                CartSetLineItemTotalPriceActionQueryBuilderDsl.Of);
        }


    }
}
