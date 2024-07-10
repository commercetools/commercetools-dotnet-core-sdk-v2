using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartRemoveDiscountCodeActionQueryBuilderDsl
    {
        public CartRemoveDiscountCodeActionQueryBuilderDsl()
        {
        }

        public static CartRemoveDiscountCodeActionQueryBuilderDsl Of()
        {
            return new CartRemoveDiscountCodeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartRemoveDiscountCodeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartRemoveDiscountCodeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartRemoveDiscountCodeActionQueryBuilderDsl>(p, CartRemoveDiscountCodeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartRemoveDiscountCodeActionQueryBuilderDsl> DiscountCode(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartRemoveDiscountCodeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discountCode"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeReferenceQueryBuilderDsl.Of())),
                CartRemoveDiscountCodeActionQueryBuilderDsl.Of);
        }


    }
}
