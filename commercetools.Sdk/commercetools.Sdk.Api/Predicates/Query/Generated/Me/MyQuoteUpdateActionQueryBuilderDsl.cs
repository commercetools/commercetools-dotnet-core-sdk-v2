using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyQuoteUpdateActionQueryBuilderDsl
    {
        public MyQuoteUpdateActionQueryBuilderDsl()
        {
        }

        public static MyQuoteUpdateActionQueryBuilderDsl Of()
        {
            return new MyQuoteUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyQuoteUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyQuoteUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyQuoteUpdateActionQueryBuilderDsl>(p, MyQuoteUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<MyQuoteUpdateActionQueryBuilderDsl> AsChangeMyQuoteState(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyQuoteChangeMyQuoteStateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyQuoteChangeMyQuoteStateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyQuoteUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyQuoteChangeMyQuoteStateActionQueryBuilderDsl.Of()),
                MyQuoteUpdateActionQueryBuilderDsl.Of);
        }
    }
}
