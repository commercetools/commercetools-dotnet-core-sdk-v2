using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class DiscountedLineItemPriceDraftQueryBuilderDsl
    {
        public DiscountedLineItemPriceDraftQueryBuilderDsl()
        {
        }

        public static DiscountedLineItemPriceDraftQueryBuilderDsl Of()
        {
            return new DiscountedLineItemPriceDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<DiscountedLineItemPriceDraftQueryBuilderDsl> Value(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountedLineItemPriceDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("value"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                DiscountedLineItemPriceDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<DiscountedLineItemPriceDraftQueryBuilderDsl> IncludedDiscounts(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.DiscountedLineItemPortionDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.DiscountedLineItemPortionDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountedLineItemPriceDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("includedDiscounts"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.DiscountedLineItemPortionDraftQueryBuilderDsl.Of())),
                DiscountedLineItemPriceDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<DiscountedLineItemPriceDraftQueryBuilderDsl> IncludedDiscounts()
        {
            return new CollectionPredicateBuilder<DiscountedLineItemPriceDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("includedDiscounts")),
                    p => new CombinationQueryPredicate<DiscountedLineItemPriceDraftQueryBuilderDsl>(p, DiscountedLineItemPriceDraftQueryBuilderDsl.Of));
        }

    }
}
