using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class QuoteRequestStateChangedMessagePayloadQueryBuilderDsl
    {
        public QuoteRequestStateChangedMessagePayloadQueryBuilderDsl()
        {
        }

        public static QuoteRequestStateChangedMessagePayloadQueryBuilderDsl Of()
        {
            return new QuoteRequestStateChangedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<QuoteRequestStateChangedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<QuoteRequestStateChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<QuoteRequestStateChangedMessagePayloadQueryBuilderDsl>(p, QuoteRequestStateChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteRequestStateChangedMessagePayloadQueryBuilderDsl, string> QuoteRequestState()
        {
            return new ComparisonPredicateBuilder<QuoteRequestStateChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quoteRequestState")),
            p => new CombinationQueryPredicate<QuoteRequestStateChangedMessagePayloadQueryBuilderDsl>(p, QuoteRequestStateChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteRequestStateChangedMessagePayloadQueryBuilderDsl, string> OldQuoteRequestState()
        {
            return new ComparisonPredicateBuilder<QuoteRequestStateChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldQuoteRequestState")),
            p => new CombinationQueryPredicate<QuoteRequestStateChangedMessagePayloadQueryBuilderDsl>(p, QuoteRequestStateChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
