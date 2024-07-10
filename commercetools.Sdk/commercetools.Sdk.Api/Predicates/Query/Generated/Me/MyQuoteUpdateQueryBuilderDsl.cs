using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyQuoteUpdateQueryBuilderDsl
    {
        public MyQuoteUpdateQueryBuilderDsl()
        {
        }

        public static MyQuoteUpdateQueryBuilderDsl Of()
        {
            return new MyQuoteUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyQuoteUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<MyQuoteUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<MyQuoteUpdateQueryBuilderDsl>(p, MyQuoteUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyQuoteUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyQuoteUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyQuoteUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyQuoteUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyQuoteUpdateActionQueryBuilderDsl.Of())),
                MyQuoteUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<MyQuoteUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<MyQuoteUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<MyQuoteUpdateQueryBuilderDsl>(p, MyQuoteUpdateQueryBuilderDsl.Of));
        }

    }
}
