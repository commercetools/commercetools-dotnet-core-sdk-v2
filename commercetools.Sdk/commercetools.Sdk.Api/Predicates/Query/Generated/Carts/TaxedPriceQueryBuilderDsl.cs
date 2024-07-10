using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class TaxedPriceQueryBuilderDsl
    {
        public TaxedPriceQueryBuilderDsl()
        {
        }

        public static TaxedPriceQueryBuilderDsl Of()
        {
            return new TaxedPriceQueryBuilderDsl();
        }

        public CombinationQueryPredicate<TaxedPriceQueryBuilderDsl> TotalNet(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TaxedPriceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("totalNet"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl.Of())),
                TaxedPriceQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<TaxedPriceQueryBuilderDsl> TotalGross(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TaxedPriceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("totalGross"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl.Of())),
                TaxedPriceQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<TaxedPriceQueryBuilderDsl> TaxPortions(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.TaxPortionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.TaxPortionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TaxedPriceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxPortions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.TaxPortionQueryBuilderDsl.Of())),
                TaxedPriceQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<TaxedPriceQueryBuilderDsl> TaxPortions()
        {
            return new CollectionPredicateBuilder<TaxedPriceQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("taxPortions")),
                    p => new CombinationQueryPredicate<TaxedPriceQueryBuilderDsl>(p, TaxedPriceQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<TaxedPriceQueryBuilderDsl> TotalTax(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TaxedPriceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("totalTax"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl.Of())),
                TaxedPriceQueryBuilderDsl.Of);
        }


    }
}
