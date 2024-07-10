using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class DiscountedLineItemPortionDraftQueryBuilderDsl
    {
        public DiscountedLineItemPortionDraftQueryBuilderDsl()
        {
        }

        public static DiscountedLineItemPortionDraftQueryBuilderDsl Of()
        {
            return new DiscountedLineItemPortionDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<DiscountedLineItemPortionDraftQueryBuilderDsl> Discount(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountedLineItemPortionDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discount"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                DiscountedLineItemPortionDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<DiscountedLineItemPortionDraftQueryBuilderDsl> DiscountedAmount(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountedLineItemPortionDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discountedAmount"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyDraftQueryBuilderDsl.Of())),
                DiscountedLineItemPortionDraftQueryBuilderDsl.Of);
        }


    }
}
