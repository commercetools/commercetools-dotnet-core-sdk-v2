using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.StandalonePrices
{

    public partial class StagedStandalonePriceQueryBuilderDsl
    {
        public StagedStandalonePriceQueryBuilderDsl()
        {
        }

        public static StagedStandalonePriceQueryBuilderDsl Of()
        {
            return new StagedStandalonePriceQueryBuilderDsl();
        }

        public CombinationQueryPredicate<StagedStandalonePriceQueryBuilderDsl> Value(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedStandalonePriceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("value"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl.Of())),
                StagedStandalonePriceQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedStandalonePriceQueryBuilderDsl> Discounted(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.DiscountedPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.DiscountedPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedStandalonePriceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discounted"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.DiscountedPriceQueryBuilderDsl.Of())),
                StagedStandalonePriceQueryBuilderDsl.Of);
        }


    }
}
