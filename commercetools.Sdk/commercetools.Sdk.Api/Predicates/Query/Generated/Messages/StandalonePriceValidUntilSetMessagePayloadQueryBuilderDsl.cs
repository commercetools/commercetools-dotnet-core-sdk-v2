using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StandalonePriceValidUntilSetMessagePayloadQueryBuilderDsl
    {
        public StandalonePriceValidUntilSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static StandalonePriceValidUntilSetMessagePayloadQueryBuilderDsl Of()
        {
            return new StandalonePriceValidUntilSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandalonePriceValidUntilSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StandalonePriceValidUntilSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StandalonePriceValidUntilSetMessagePayloadQueryBuilderDsl>(p, StandalonePriceValidUntilSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceValidUntilSetMessagePayloadQueryBuilderDsl, DateTime> ValidUntil()
        {
            return new ComparisonPredicateBuilder<StandalonePriceValidUntilSetMessagePayloadQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validUntil")),
            p => new CombinationQueryPredicate<StandalonePriceValidUntilSetMessagePayloadQueryBuilderDsl>(p, StandalonePriceValidUntilSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceValidUntilSetMessagePayloadQueryBuilderDsl, DateTime> PreviousValidUntil()
        {
            return new ComparisonPredicateBuilder<StandalonePriceValidUntilSetMessagePayloadQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("previousValidUntil")),
            p => new CombinationQueryPredicate<StandalonePriceValidUntilSetMessagePayloadQueryBuilderDsl>(p, StandalonePriceValidUntilSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
