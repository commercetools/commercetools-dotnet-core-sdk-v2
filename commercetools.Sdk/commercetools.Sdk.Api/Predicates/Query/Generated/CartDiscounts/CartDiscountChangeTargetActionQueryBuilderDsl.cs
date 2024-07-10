using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CartDiscountChangeTargetActionQueryBuilderDsl
    {
        public CartDiscountChangeTargetActionQueryBuilderDsl()
        {
        }

        public static CartDiscountChangeTargetActionQueryBuilderDsl Of()
        {
            return new CartDiscountChangeTargetActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartDiscountChangeTargetActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartDiscountChangeTargetActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartDiscountChangeTargetActionQueryBuilderDsl>(p, CartDiscountChangeTargetActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartDiscountChangeTargetActionQueryBuilderDsl> Target(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountTargetQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountTargetQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartDiscountChangeTargetActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("target"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountTargetQueryBuilderDsl.Of())),
                CartDiscountChangeTargetActionQueryBuilderDsl.Of);
        }


    }
}
