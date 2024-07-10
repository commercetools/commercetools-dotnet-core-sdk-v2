using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartRemoveItemShippingAddressActionQueryBuilderDsl
    {
        public CartRemoveItemShippingAddressActionQueryBuilderDsl()
        {
        }

        public static CartRemoveItemShippingAddressActionQueryBuilderDsl Of()
        {
            return new CartRemoveItemShippingAddressActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartRemoveItemShippingAddressActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartRemoveItemShippingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartRemoveItemShippingAddressActionQueryBuilderDsl>(p, CartRemoveItemShippingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartRemoveItemShippingAddressActionQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<CartRemoveItemShippingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<CartRemoveItemShippingAddressActionQueryBuilderDsl>(p, CartRemoveItemShippingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
