// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class QuoteStateChangedMessagePayloadQueryBuilderDsl
    {
        public QuoteStateChangedMessagePayloadQueryBuilderDsl()
        {
        }

        public static QuoteStateChangedMessagePayloadQueryBuilderDsl Of()
        {
            return new QuoteStateChangedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<QuoteStateChangedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<QuoteStateChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<QuoteStateChangedMessagePayloadQueryBuilderDsl>(p, QuoteStateChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteStateChangedMessagePayloadQueryBuilderDsl, string> QuoteState()
        {
            return new ComparisonPredicateBuilder<QuoteStateChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quoteState")),
            p => new CombinationQueryPredicate<QuoteStateChangedMessagePayloadQueryBuilderDsl>(p, QuoteStateChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteStateChangedMessagePayloadQueryBuilderDsl, string> OldQuoteState()
        {
            return new ComparisonPredicateBuilder<QuoteStateChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldQuoteState")),
            p => new CombinationQueryPredicate<QuoteStateChangedMessagePayloadQueryBuilderDsl>(p, QuoteStateChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
