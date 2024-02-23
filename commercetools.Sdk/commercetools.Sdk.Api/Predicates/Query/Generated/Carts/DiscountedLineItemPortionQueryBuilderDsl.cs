using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class DiscountedLineItemPortionQueryBuilderDsl
    {
        public DiscountedLineItemPortionQueryBuilderDsl()
        {
        }

        public static DiscountedLineItemPortionQueryBuilderDsl Of()
        {
            return new DiscountedLineItemPortionQueryBuilderDsl();
        }

        public CombinationQueryPredicate<DiscountedLineItemPortionQueryBuilderDsl> Discount(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountedLineItemPortionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discount"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                DiscountedLineItemPortionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<DiscountedLineItemPortionQueryBuilderDsl> DiscountedAmount(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountedLineItemPortionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discountedAmount"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl.Of())),
                DiscountedLineItemPortionQueryBuilderDsl.Of);
        }


    }
}
