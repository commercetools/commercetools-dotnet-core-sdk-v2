using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Common
{

    public partial class DiscountedPriceDraftQueryBuilderDsl
    {
        public DiscountedPriceDraftQueryBuilderDsl()
        {
        }

        public static DiscountedPriceDraftQueryBuilderDsl Of()
        {
            return new DiscountedPriceDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<DiscountedPriceDraftQueryBuilderDsl> Value(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountedPriceDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("value"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                DiscountedPriceDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<DiscountedPriceDraftQueryBuilderDsl> Discount(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountedPriceDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discount"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountReferenceQueryBuilderDsl.Of())),
                DiscountedPriceDraftQueryBuilderDsl.Of);
        }


    }
}
