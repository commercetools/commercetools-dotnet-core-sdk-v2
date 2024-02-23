using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.StandalonePrices
{

    public partial class StandalonePriceSetDiscountedPriceActionQueryBuilderDsl
    {
        public StandalonePriceSetDiscountedPriceActionQueryBuilderDsl()
        {
        }

        public static StandalonePriceSetDiscountedPriceActionQueryBuilderDsl Of()
        {
            return new StandalonePriceSetDiscountedPriceActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandalonePriceSetDiscountedPriceActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StandalonePriceSetDiscountedPriceActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StandalonePriceSetDiscountedPriceActionQueryBuilderDsl>(p, StandalonePriceSetDiscountedPriceActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StandalonePriceSetDiscountedPriceActionQueryBuilderDsl> Discounted(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.DiscountedPriceDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.DiscountedPriceDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceSetDiscountedPriceActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discounted"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.DiscountedPriceDraftQueryBuilderDsl.Of())),
                StandalonePriceSetDiscountedPriceActionQueryBuilderDsl.Of);
        }


    }
}
