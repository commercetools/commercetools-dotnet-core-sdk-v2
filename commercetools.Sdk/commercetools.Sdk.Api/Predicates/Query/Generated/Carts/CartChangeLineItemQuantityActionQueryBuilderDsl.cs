using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartChangeLineItemQuantityActionQueryBuilderDsl
    {
        public CartChangeLineItemQuantityActionQueryBuilderDsl()
        {
        }

        public static CartChangeLineItemQuantityActionQueryBuilderDsl Of()
        {
            return new CartChangeLineItemQuantityActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartChangeLineItemQuantityActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartChangeLineItemQuantityActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartChangeLineItemQuantityActionQueryBuilderDsl>(p, CartChangeLineItemQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartChangeLineItemQuantityActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<CartChangeLineItemQuantityActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<CartChangeLineItemQuantityActionQueryBuilderDsl>(p, CartChangeLineItemQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartChangeLineItemQuantityActionQueryBuilderDsl, string> LineItemKey()
        {
            return new ComparisonPredicateBuilder<CartChangeLineItemQuantityActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemKey")),
            p => new CombinationQueryPredicate<CartChangeLineItemQuantityActionQueryBuilderDsl>(p, CartChangeLineItemQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartChangeLineItemQuantityActionQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<CartChangeLineItemQuantityActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<CartChangeLineItemQuantityActionQueryBuilderDsl>(p, CartChangeLineItemQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartChangeLineItemQuantityActionQueryBuilderDsl> ExternalPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartChangeLineItemQuantityActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                CartChangeLineItemQuantityActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartChangeLineItemQuantityActionQueryBuilderDsl> ExternalTotalPrice(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalLineItemTotalPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalLineItemTotalPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartChangeLineItemQuantityActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalTotalPrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ExternalLineItemTotalPriceQueryBuilderDsl.Of())),
                CartChangeLineItemQuantityActionQueryBuilderDsl.Of);
        }


    }
}
