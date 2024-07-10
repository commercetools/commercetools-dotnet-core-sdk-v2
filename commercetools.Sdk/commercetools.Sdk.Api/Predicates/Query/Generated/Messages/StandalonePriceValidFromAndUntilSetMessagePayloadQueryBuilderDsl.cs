using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StandalonePriceValidFromAndUntilSetMessagePayloadQueryBuilderDsl
    {
        public StandalonePriceValidFromAndUntilSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static StandalonePriceValidFromAndUntilSetMessagePayloadQueryBuilderDsl Of()
        {
            return new StandalonePriceValidFromAndUntilSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandalonePriceValidFromAndUntilSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StandalonePriceValidFromAndUntilSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StandalonePriceValidFromAndUntilSetMessagePayloadQueryBuilderDsl>(p, StandalonePriceValidFromAndUntilSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceValidFromAndUntilSetMessagePayloadQueryBuilderDsl, DateTime> ValidFrom()
        {
            return new ComparisonPredicateBuilder<StandalonePriceValidFromAndUntilSetMessagePayloadQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validFrom")),
            p => new CombinationQueryPredicate<StandalonePriceValidFromAndUntilSetMessagePayloadQueryBuilderDsl>(p, StandalonePriceValidFromAndUntilSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceValidFromAndUntilSetMessagePayloadQueryBuilderDsl, DateTime> PreviousValidFrom()
        {
            return new ComparisonPredicateBuilder<StandalonePriceValidFromAndUntilSetMessagePayloadQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("previousValidFrom")),
            p => new CombinationQueryPredicate<StandalonePriceValidFromAndUntilSetMessagePayloadQueryBuilderDsl>(p, StandalonePriceValidFromAndUntilSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceValidFromAndUntilSetMessagePayloadQueryBuilderDsl, DateTime> ValidUntil()
        {
            return new ComparisonPredicateBuilder<StandalonePriceValidFromAndUntilSetMessagePayloadQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validUntil")),
            p => new CombinationQueryPredicate<StandalonePriceValidFromAndUntilSetMessagePayloadQueryBuilderDsl>(p, StandalonePriceValidFromAndUntilSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceValidFromAndUntilSetMessagePayloadQueryBuilderDsl, DateTime> PreviousValidUntil()
        {
            return new ComparisonPredicateBuilder<StandalonePriceValidFromAndUntilSetMessagePayloadQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("previousValidUntil")),
            p => new CombinationQueryPredicate<StandalonePriceValidFromAndUntilSetMessagePayloadQueryBuilderDsl>(p, StandalonePriceValidFromAndUntilSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
