using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StandalonePriceTierRemovedMessagePayloadQueryBuilderDsl
    {
        public StandalonePriceTierRemovedMessagePayloadQueryBuilderDsl()
        {
        }

        public static StandalonePriceTierRemovedMessagePayloadQueryBuilderDsl Of()
        {
            return new StandalonePriceTierRemovedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandalonePriceTierRemovedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StandalonePriceTierRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StandalonePriceTierRemovedMessagePayloadQueryBuilderDsl>(p, StandalonePriceTierRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StandalonePriceTierRemovedMessagePayloadQueryBuilderDsl> RemovedTier(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.PriceTierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.PriceTierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceTierRemovedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("removedTier"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.PriceTierQueryBuilderDsl.Of())),
                StandalonePriceTierRemovedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
