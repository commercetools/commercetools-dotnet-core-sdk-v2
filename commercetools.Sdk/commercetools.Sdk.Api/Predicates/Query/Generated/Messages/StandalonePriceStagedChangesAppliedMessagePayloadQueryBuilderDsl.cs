using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StandalonePriceStagedChangesAppliedMessagePayloadQueryBuilderDsl
    {
        public StandalonePriceStagedChangesAppliedMessagePayloadQueryBuilderDsl()
        {
        }

        public static StandalonePriceStagedChangesAppliedMessagePayloadQueryBuilderDsl Of()
        {
            return new StandalonePriceStagedChangesAppliedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandalonePriceStagedChangesAppliedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StandalonePriceStagedChangesAppliedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StandalonePriceStagedChangesAppliedMessagePayloadQueryBuilderDsl>(p, StandalonePriceStagedChangesAppliedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StandalonePriceStagedChangesAppliedMessagePayloadQueryBuilderDsl> StagedChanges(
            Func<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StagedStandalonePriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StagedStandalonePriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceStagedChangesAppliedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("stagedChanges"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StagedStandalonePriceQueryBuilderDsl.Of())),
                StandalonePriceStagedChangesAppliedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
