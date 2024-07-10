using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StandalonePriceActiveChangedMessagePayloadQueryBuilderDsl
    {
        public StandalonePriceActiveChangedMessagePayloadQueryBuilderDsl()
        {
        }

        public static StandalonePriceActiveChangedMessagePayloadQueryBuilderDsl Of()
        {
            return new StandalonePriceActiveChangedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandalonePriceActiveChangedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StandalonePriceActiveChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StandalonePriceActiveChangedMessagePayloadQueryBuilderDsl>(p, StandalonePriceActiveChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceActiveChangedMessagePayloadQueryBuilderDsl, bool> Active()
        {
            return new ComparisonPredicateBuilder<StandalonePriceActiveChangedMessagePayloadQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("active")),
            p => new CombinationQueryPredicate<StandalonePriceActiveChangedMessagePayloadQueryBuilderDsl>(p, StandalonePriceActiveChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceActiveChangedMessagePayloadQueryBuilderDsl, bool> OldActive()
        {
            return new ComparisonPredicateBuilder<StandalonePriceActiveChangedMessagePayloadQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldActive")),
            p => new CombinationQueryPredicate<StandalonePriceActiveChangedMessagePayloadQueryBuilderDsl>(p, StandalonePriceActiveChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
