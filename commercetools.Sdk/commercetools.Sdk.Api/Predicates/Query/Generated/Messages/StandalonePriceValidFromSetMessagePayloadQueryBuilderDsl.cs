using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StandalonePriceValidFromSetMessagePayloadQueryBuilderDsl
    {
        public StandalonePriceValidFromSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static StandalonePriceValidFromSetMessagePayloadQueryBuilderDsl Of()
        {
            return new StandalonePriceValidFromSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandalonePriceValidFromSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StandalonePriceValidFromSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StandalonePriceValidFromSetMessagePayloadQueryBuilderDsl>(p, StandalonePriceValidFromSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceValidFromSetMessagePayloadQueryBuilderDsl, DateTime> ValidFrom()
        {
            return new ComparisonPredicateBuilder<StandalonePriceValidFromSetMessagePayloadQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validFrom")),
            p => new CombinationQueryPredicate<StandalonePriceValidFromSetMessagePayloadQueryBuilderDsl>(p, StandalonePriceValidFromSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceValidFromSetMessagePayloadQueryBuilderDsl, DateTime> PreviousValidFrom()
        {
            return new ComparisonPredicateBuilder<StandalonePriceValidFromSetMessagePayloadQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("previousValidFrom")),
            p => new CombinationQueryPredicate<StandalonePriceValidFromSetMessagePayloadQueryBuilderDsl>(p, StandalonePriceValidFromSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
