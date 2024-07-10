using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyQuoteRequestUpdateQueryBuilderDsl
    {
        public MyQuoteRequestUpdateQueryBuilderDsl()
        {
        }

        public static MyQuoteRequestUpdateQueryBuilderDsl Of()
        {
            return new MyQuoteRequestUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyQuoteRequestUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<MyQuoteRequestUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<MyQuoteRequestUpdateQueryBuilderDsl>(p, MyQuoteRequestUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyQuoteRequestUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyQuoteRequestUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyQuoteRequestUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyQuoteRequestUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyQuoteRequestUpdateActionQueryBuilderDsl.Of())),
                MyQuoteRequestUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<MyQuoteRequestUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<MyQuoteRequestUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<MyQuoteRequestUpdateQueryBuilderDsl>(p, MyQuoteRequestUpdateQueryBuilderDsl.Of));
        }

    }
}
