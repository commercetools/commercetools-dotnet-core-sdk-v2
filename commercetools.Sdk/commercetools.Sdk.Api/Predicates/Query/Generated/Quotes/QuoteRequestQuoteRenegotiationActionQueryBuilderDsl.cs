using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Quotes
{

    public partial class QuoteRequestQuoteRenegotiationActionQueryBuilderDsl
    {
        public QuoteRequestQuoteRenegotiationActionQueryBuilderDsl()
        {
        }

        public static QuoteRequestQuoteRenegotiationActionQueryBuilderDsl Of()
        {
            return new QuoteRequestQuoteRenegotiationActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<QuoteRequestQuoteRenegotiationActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<QuoteRequestQuoteRenegotiationActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<QuoteRequestQuoteRenegotiationActionQueryBuilderDsl>(p, QuoteRequestQuoteRenegotiationActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteRequestQuoteRenegotiationActionQueryBuilderDsl, string> BuyerComment()
        {
            return new ComparisonPredicateBuilder<QuoteRequestQuoteRenegotiationActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("buyerComment")),
            p => new CombinationQueryPredicate<QuoteRequestQuoteRenegotiationActionQueryBuilderDsl>(p, QuoteRequestQuoteRenegotiationActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
