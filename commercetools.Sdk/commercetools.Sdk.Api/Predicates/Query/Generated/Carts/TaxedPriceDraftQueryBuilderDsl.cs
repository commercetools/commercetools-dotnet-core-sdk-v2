using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class TaxedPriceDraftQueryBuilderDsl
    {
        public TaxedPriceDraftQueryBuilderDsl()
        {
        }

        public static TaxedPriceDraftQueryBuilderDsl Of()
        {
            return new TaxedPriceDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<TaxedPriceDraftQueryBuilderDsl> TotalNet(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TaxedPriceDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("totalNet"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                TaxedPriceDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<TaxedPriceDraftQueryBuilderDsl> TotalGross(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TaxedPriceDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("totalGross"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                TaxedPriceDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<TaxedPriceDraftQueryBuilderDsl> TaxPortions(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.TaxPortionDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.TaxPortionDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TaxedPriceDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxPortions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.TaxPortionDraftQueryBuilderDsl.Of())),
                TaxedPriceDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<TaxedPriceDraftQueryBuilderDsl> TaxPortions()
        {
            return new CollectionPredicateBuilder<TaxedPriceDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("taxPortions")),
                    p => new CombinationQueryPredicate<TaxedPriceDraftQueryBuilderDsl>(p, TaxedPriceDraftQueryBuilderDsl.Of));
        }

    }
}
