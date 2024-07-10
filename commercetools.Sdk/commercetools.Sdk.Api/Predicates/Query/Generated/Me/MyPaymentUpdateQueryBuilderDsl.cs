using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyPaymentUpdateQueryBuilderDsl
    {
        public MyPaymentUpdateQueryBuilderDsl()
        {
        }

        public static MyPaymentUpdateQueryBuilderDsl Of()
        {
            return new MyPaymentUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyPaymentUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<MyPaymentUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<MyPaymentUpdateQueryBuilderDsl>(p, MyPaymentUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyPaymentUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyPaymentUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyPaymentUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyPaymentUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyPaymentUpdateActionQueryBuilderDsl.Of())),
                MyPaymentUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<MyPaymentUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<MyPaymentUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<MyPaymentUpdateQueryBuilderDsl>(p, MyPaymentUpdateQueryBuilderDsl.Of));
        }

    }
}
