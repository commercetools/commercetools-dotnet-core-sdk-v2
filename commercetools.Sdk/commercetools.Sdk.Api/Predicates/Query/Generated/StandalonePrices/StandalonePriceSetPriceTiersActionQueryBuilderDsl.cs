using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.StandalonePrices
{

    public partial class StandalonePriceSetPriceTiersActionQueryBuilderDsl
    {
        public StandalonePriceSetPriceTiersActionQueryBuilderDsl()
        {
        }

        public static StandalonePriceSetPriceTiersActionQueryBuilderDsl Of()
        {
            return new StandalonePriceSetPriceTiersActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandalonePriceSetPriceTiersActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StandalonePriceSetPriceTiersActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StandalonePriceSetPriceTiersActionQueryBuilderDsl>(p, StandalonePriceSetPriceTiersActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StandalonePriceSetPriceTiersActionQueryBuilderDsl> Tiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.PriceTierDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.PriceTierDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceSetPriceTiersActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("tiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.PriceTierDraftQueryBuilderDsl.Of())),
                StandalonePriceSetPriceTiersActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StandalonePriceSetPriceTiersActionQueryBuilderDsl> Tiers()
        {
            return new CollectionPredicateBuilder<StandalonePriceSetPriceTiersActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("tiers")),
                    p => new CombinationQueryPredicate<StandalonePriceSetPriceTiersActionQueryBuilderDsl>(p, StandalonePriceSetPriceTiersActionQueryBuilderDsl.Of));
        }

    }
}
