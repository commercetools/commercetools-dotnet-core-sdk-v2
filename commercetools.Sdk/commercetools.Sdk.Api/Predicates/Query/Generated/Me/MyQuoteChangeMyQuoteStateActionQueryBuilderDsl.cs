// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyQuoteChangeMyQuoteStateActionQueryBuilderDsl
    {
        public MyQuoteChangeMyQuoteStateActionQueryBuilderDsl()
        {
        }

        public static MyQuoteChangeMyQuoteStateActionQueryBuilderDsl Of()
        {
            return new MyQuoteChangeMyQuoteStateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyQuoteChangeMyQuoteStateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyQuoteChangeMyQuoteStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyQuoteChangeMyQuoteStateActionQueryBuilderDsl>(p, MyQuoteChangeMyQuoteStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyQuoteChangeMyQuoteStateActionQueryBuilderDsl, string> QuoteState()
        {
            return new ComparisonPredicateBuilder<MyQuoteChangeMyQuoteStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quoteState")),
            p => new CombinationQueryPredicate<MyQuoteChangeMyQuoteStateActionQueryBuilderDsl>(p, MyQuoteChangeMyQuoteStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
