using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class TaxedItemPriceQueryBuilderDsl
    {
        public TaxedItemPriceQueryBuilderDsl()
        {
        }

        public static TaxedItemPriceQueryBuilderDsl Of()
        {
            return new TaxedItemPriceQueryBuilderDsl();
        }

        public CombinationQueryPredicate<TaxedItemPriceQueryBuilderDsl> TotalNet(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TaxedItemPriceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("totalNet"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl.Of())),
                TaxedItemPriceQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<TaxedItemPriceQueryBuilderDsl> TotalGross(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TaxedItemPriceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("totalGross"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl.Of())),
                TaxedItemPriceQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<TaxedItemPriceQueryBuilderDsl> TaxPortions(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.TaxPortionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.TaxPortionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TaxedItemPriceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxPortions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.TaxPortionQueryBuilderDsl.Of())),
                TaxedItemPriceQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<TaxedItemPriceQueryBuilderDsl> TaxPortions()
        {
            return new CollectionPredicateBuilder<TaxedItemPriceQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("taxPortions")),
                    p => new CombinationQueryPredicate<TaxedItemPriceQueryBuilderDsl>(p, TaxedItemPriceQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<TaxedItemPriceQueryBuilderDsl> TotalTax(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TaxedItemPriceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("totalTax"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl.Of())),
                TaxedItemPriceQueryBuilderDsl.Of);
        }


    }
}
