// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Quotes
{

    public partial class QuoteChangeQuoteStateActionQueryBuilderDsl
    {
        public QuoteChangeQuoteStateActionQueryBuilderDsl()
        {
        }

        public static QuoteChangeQuoteStateActionQueryBuilderDsl Of()
        {
            return new QuoteChangeQuoteStateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<QuoteChangeQuoteStateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<QuoteChangeQuoteStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<QuoteChangeQuoteStateActionQueryBuilderDsl>(p, QuoteChangeQuoteStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteChangeQuoteStateActionQueryBuilderDsl, string> QuoteState()
        {
            return new ComparisonPredicateBuilder<QuoteChangeQuoteStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quoteState")),
            p => new CombinationQueryPredicate<QuoteChangeQuoteStateActionQueryBuilderDsl>(p, QuoteChangeQuoteStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
