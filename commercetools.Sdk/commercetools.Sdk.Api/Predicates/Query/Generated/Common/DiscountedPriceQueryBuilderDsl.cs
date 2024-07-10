using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Common
{

    public partial class DiscountedPriceQueryBuilderDsl
    {
        public DiscountedPriceQueryBuilderDsl()
        {
        }

        public static DiscountedPriceQueryBuilderDsl Of()
        {
            return new DiscountedPriceQueryBuilderDsl();
        }

        public CombinationQueryPredicate<DiscountedPriceQueryBuilderDsl> Value(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountedPriceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("value"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl.Of())),
                DiscountedPriceQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<DiscountedPriceQueryBuilderDsl> Discount(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountedPriceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discount"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountReferenceQueryBuilderDsl.Of())),
                DiscountedPriceQueryBuilderDsl.Of);
        }


    }
}
