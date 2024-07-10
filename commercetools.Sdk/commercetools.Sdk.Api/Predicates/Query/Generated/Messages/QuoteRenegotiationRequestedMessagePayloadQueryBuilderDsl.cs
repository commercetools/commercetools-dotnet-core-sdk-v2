// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class QuoteRenegotiationRequestedMessagePayloadQueryBuilderDsl
    {
        public QuoteRenegotiationRequestedMessagePayloadQueryBuilderDsl()
        {
        }

        public static QuoteRenegotiationRequestedMessagePayloadQueryBuilderDsl Of()
        {
            return new QuoteRenegotiationRequestedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<QuoteRenegotiationRequestedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<QuoteRenegotiationRequestedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<QuoteRenegotiationRequestedMessagePayloadQueryBuilderDsl>(p, QuoteRenegotiationRequestedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteRenegotiationRequestedMessagePayloadQueryBuilderDsl, string> BuyerComment()
        {
            return new ComparisonPredicateBuilder<QuoteRenegotiationRequestedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("buyerComment")),
            p => new CombinationQueryPredicate<QuoteRenegotiationRequestedMessagePayloadQueryBuilderDsl>(p, QuoteRenegotiationRequestedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
