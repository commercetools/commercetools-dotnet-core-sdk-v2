using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StandalonePriceTierAddedMessagePayloadQueryBuilderDsl
    {
        public StandalonePriceTierAddedMessagePayloadQueryBuilderDsl()
        {
        }

        public static StandalonePriceTierAddedMessagePayloadQueryBuilderDsl Of()
        {
            return new StandalonePriceTierAddedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandalonePriceTierAddedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StandalonePriceTierAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StandalonePriceTierAddedMessagePayloadQueryBuilderDsl>(p, StandalonePriceTierAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StandalonePriceTierAddedMessagePayloadQueryBuilderDsl> Tier(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.PriceTierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.PriceTierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceTierAddedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("tier"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.PriceTierQueryBuilderDsl.Of())),
                StandalonePriceTierAddedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
