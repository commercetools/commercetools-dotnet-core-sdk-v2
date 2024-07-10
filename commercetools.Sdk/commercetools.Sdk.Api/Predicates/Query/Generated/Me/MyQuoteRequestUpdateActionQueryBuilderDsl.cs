using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyQuoteRequestUpdateActionQueryBuilderDsl
    {
        public MyQuoteRequestUpdateActionQueryBuilderDsl()
        {
        }

        public static MyQuoteRequestUpdateActionQueryBuilderDsl Of()
        {
            return new MyQuoteRequestUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyQuoteRequestUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyQuoteRequestUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyQuoteRequestUpdateActionQueryBuilderDsl>(p, MyQuoteRequestUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<MyQuoteRequestUpdateActionQueryBuilderDsl> AsCancelQuoteRequest(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyQuoteRequestCancelActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyQuoteRequestCancelActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyQuoteRequestUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyQuoteRequestCancelActionQueryBuilderDsl.Of()),
                MyQuoteRequestUpdateActionQueryBuilderDsl.Of);
        }
    }
}
