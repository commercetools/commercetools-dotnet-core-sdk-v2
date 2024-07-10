using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.QuoteRequests
{

    public partial class QuoteRequestChangeQuoteRequestStateActionQueryBuilderDsl
    {
        public QuoteRequestChangeQuoteRequestStateActionQueryBuilderDsl()
        {
        }

        public static QuoteRequestChangeQuoteRequestStateActionQueryBuilderDsl Of()
        {
            return new QuoteRequestChangeQuoteRequestStateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<QuoteRequestChangeQuoteRequestStateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<QuoteRequestChangeQuoteRequestStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<QuoteRequestChangeQuoteRequestStateActionQueryBuilderDsl>(p, QuoteRequestChangeQuoteRequestStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteRequestChangeQuoteRequestStateActionQueryBuilderDsl, string> QuoteRequestState()
        {
            return new ComparisonPredicateBuilder<QuoteRequestChangeQuoteRequestStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quoteRequestState")),
            p => new CombinationQueryPredicate<QuoteRequestChangeQuoteRequestStateActionQueryBuilderDsl>(p, QuoteRequestChangeQuoteRequestStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
