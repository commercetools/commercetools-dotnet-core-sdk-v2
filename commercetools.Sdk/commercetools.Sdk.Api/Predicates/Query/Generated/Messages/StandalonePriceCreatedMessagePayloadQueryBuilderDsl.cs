using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StandalonePriceCreatedMessagePayloadQueryBuilderDsl
    {
        public StandalonePriceCreatedMessagePayloadQueryBuilderDsl()
        {
        }

        public static StandalonePriceCreatedMessagePayloadQueryBuilderDsl Of()
        {
            return new StandalonePriceCreatedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandalonePriceCreatedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StandalonePriceCreatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StandalonePriceCreatedMessagePayloadQueryBuilderDsl>(p, StandalonePriceCreatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StandalonePriceCreatedMessagePayloadQueryBuilderDsl> StandalonePrice(
            Func<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceCreatedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("standalonePrice"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceQueryBuilderDsl.Of())),
                StandalonePriceCreatedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
