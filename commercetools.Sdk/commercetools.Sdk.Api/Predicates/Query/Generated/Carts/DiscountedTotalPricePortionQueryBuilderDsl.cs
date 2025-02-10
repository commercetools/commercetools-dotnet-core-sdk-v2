using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class DiscountedTotalPricePortionQueryBuilderDsl
    {
        public DiscountedTotalPricePortionQueryBuilderDsl()
        {
        }

        public static DiscountedTotalPricePortionQueryBuilderDsl Of()
        {
            return new DiscountedTotalPricePortionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<DiscountedTotalPricePortionQueryBuilderDsl> Discount(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountedTotalPricePortionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discount"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                DiscountedTotalPricePortionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<DiscountedTotalPricePortionQueryBuilderDsl> DiscountedAmount(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountedTotalPricePortionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discountedAmount"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl.Of())),
                DiscountedTotalPricePortionQueryBuilderDsl.Of);
        }


    }
}
