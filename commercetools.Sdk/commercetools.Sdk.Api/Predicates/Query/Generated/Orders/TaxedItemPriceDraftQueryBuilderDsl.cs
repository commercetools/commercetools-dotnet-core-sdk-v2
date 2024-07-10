using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class TaxedItemPriceDraftQueryBuilderDsl
    {
        public TaxedItemPriceDraftQueryBuilderDsl()
        {
        }

        public static TaxedItemPriceDraftQueryBuilderDsl Of()
        {
            return new TaxedItemPriceDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<TaxedItemPriceDraftQueryBuilderDsl> TotalNet(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TaxedItemPriceDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("totalNet"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                TaxedItemPriceDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<TaxedItemPriceDraftQueryBuilderDsl> TotalGross(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TaxedItemPriceDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("totalGross"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                TaxedItemPriceDraftQueryBuilderDsl.Of);
        }


    }
}
