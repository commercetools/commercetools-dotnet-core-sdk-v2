using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartRemoveShippingMethodActionQueryBuilderDsl
    {
        public CartRemoveShippingMethodActionQueryBuilderDsl()
        {
        }

        public static CartRemoveShippingMethodActionQueryBuilderDsl Of()
        {
            return new CartRemoveShippingMethodActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartRemoveShippingMethodActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartRemoveShippingMethodActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartRemoveShippingMethodActionQueryBuilderDsl>(p, CartRemoveShippingMethodActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartRemoveShippingMethodActionQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<CartRemoveShippingMethodActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<CartRemoveShippingMethodActionQueryBuilderDsl>(p, CartRemoveShippingMethodActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
