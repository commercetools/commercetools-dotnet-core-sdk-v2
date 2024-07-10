using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StandalonePriceStagedChangesRemovedMessagePayloadQueryBuilderDsl
    {
        public StandalonePriceStagedChangesRemovedMessagePayloadQueryBuilderDsl()
        {
        }

        public static StandalonePriceStagedChangesRemovedMessagePayloadQueryBuilderDsl Of()
        {
            return new StandalonePriceStagedChangesRemovedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandalonePriceStagedChangesRemovedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StandalonePriceStagedChangesRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StandalonePriceStagedChangesRemovedMessagePayloadQueryBuilderDsl>(p, StandalonePriceStagedChangesRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StandalonePriceStagedChangesRemovedMessagePayloadQueryBuilderDsl> StagedChanges(
            Func<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StagedStandalonePriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StagedStandalonePriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceStagedChangesRemovedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("stagedChanges"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StagedStandalonePriceQueryBuilderDsl.Of())),
                StandalonePriceStagedChangesRemovedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
