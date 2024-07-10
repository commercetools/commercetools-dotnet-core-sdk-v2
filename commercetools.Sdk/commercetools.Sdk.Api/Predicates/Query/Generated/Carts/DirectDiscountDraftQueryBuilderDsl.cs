using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class DirectDiscountDraftQueryBuilderDsl
    {
        public DirectDiscountDraftQueryBuilderDsl()
        {
        }

        public static DirectDiscountDraftQueryBuilderDsl Of()
        {
            return new DirectDiscountDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<DirectDiscountDraftQueryBuilderDsl> Value(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DirectDiscountDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("value"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountValueDraftQueryBuilderDsl.Of())),
                DirectDiscountDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<DirectDiscountDraftQueryBuilderDsl> Target(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountTargetQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountTargetQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DirectDiscountDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("target"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountTargetQueryBuilderDsl.Of())),
                DirectDiscountDraftQueryBuilderDsl.Of);
        }


    }
}
