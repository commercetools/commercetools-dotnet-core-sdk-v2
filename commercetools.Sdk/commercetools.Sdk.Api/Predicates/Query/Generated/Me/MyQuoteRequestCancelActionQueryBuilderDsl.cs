// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyQuoteRequestCancelActionQueryBuilderDsl
    {
        public MyQuoteRequestCancelActionQueryBuilderDsl()
        {
        }

        public static MyQuoteRequestCancelActionQueryBuilderDsl Of()
        {
            return new MyQuoteRequestCancelActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyQuoteRequestCancelActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyQuoteRequestCancelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyQuoteRequestCancelActionQueryBuilderDsl>(p, MyQuoteRequestCancelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
