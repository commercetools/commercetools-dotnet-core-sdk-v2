using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StandalonePriceTiersSetMessagePayloadQueryBuilderDsl
    {
        public StandalonePriceTiersSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static StandalonePriceTiersSetMessagePayloadQueryBuilderDsl Of()
        {
            return new StandalonePriceTiersSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandalonePriceTiersSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StandalonePriceTiersSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StandalonePriceTiersSetMessagePayloadQueryBuilderDsl>(p, StandalonePriceTiersSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StandalonePriceTiersSetMessagePayloadQueryBuilderDsl> Tiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.PriceTierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.PriceTierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceTiersSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("tiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.PriceTierQueryBuilderDsl.Of())),
                StandalonePriceTiersSetMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StandalonePriceTiersSetMessagePayloadQueryBuilderDsl> Tiers()
        {
            return new CollectionPredicateBuilder<StandalonePriceTiersSetMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("tiers")),
                    p => new CombinationQueryPredicate<StandalonePriceTiersSetMessagePayloadQueryBuilderDsl>(p, StandalonePriceTiersSetMessagePayloadQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<StandalonePriceTiersSetMessagePayloadQueryBuilderDsl> PreviousTiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.PriceTierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.PriceTierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceTiersSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("previousTiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.PriceTierQueryBuilderDsl.Of())),
                StandalonePriceTiersSetMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StandalonePriceTiersSetMessagePayloadQueryBuilderDsl> PreviousTiers()
        {
            return new CollectionPredicateBuilder<StandalonePriceTiersSetMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("previousTiers")),
                    p => new CombinationQueryPredicate<StandalonePriceTiersSetMessagePayloadQueryBuilderDsl>(p, StandalonePriceTiersSetMessagePayloadQueryBuilderDsl.Of));
        }

    }
}
