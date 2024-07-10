using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StagedQuoteStateChangedMessagePayloadQueryBuilderDsl
    {
        public StagedQuoteStateChangedMessagePayloadQueryBuilderDsl()
        {
        }

        public static StagedQuoteStateChangedMessagePayloadQueryBuilderDsl Of()
        {
            return new StagedQuoteStateChangedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedQuoteStateChangedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StagedQuoteStateChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StagedQuoteStateChangedMessagePayloadQueryBuilderDsl>(p, StagedQuoteStateChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedQuoteStateChangedMessagePayloadQueryBuilderDsl, string> StagedQuoteState()
        {
            return new ComparisonPredicateBuilder<StagedQuoteStateChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("stagedQuoteState")),
            p => new CombinationQueryPredicate<StagedQuoteStateChangedMessagePayloadQueryBuilderDsl>(p, StagedQuoteStateChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedQuoteStateChangedMessagePayloadQueryBuilderDsl, string> OldStagedQuoteState()
        {
            return new ComparisonPredicateBuilder<StagedQuoteStateChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldStagedQuoteState")),
            p => new CombinationQueryPredicate<StagedQuoteStateChangedMessagePayloadQueryBuilderDsl>(p, StagedQuoteStateChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
