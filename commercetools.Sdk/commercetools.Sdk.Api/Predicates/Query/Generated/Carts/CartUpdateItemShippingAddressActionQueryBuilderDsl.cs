using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartUpdateItemShippingAddressActionQueryBuilderDsl
    {
        public CartUpdateItemShippingAddressActionQueryBuilderDsl()
        {
        }

        public static CartUpdateItemShippingAddressActionQueryBuilderDsl Of()
        {
            return new CartUpdateItemShippingAddressActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartUpdateItemShippingAddressActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartUpdateItemShippingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartUpdateItemShippingAddressActionQueryBuilderDsl>(p, CartUpdateItemShippingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartUpdateItemShippingAddressActionQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartUpdateItemShippingAddressActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                CartUpdateItemShippingAddressActionQueryBuilderDsl.Of);
        }


    }
}
