using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyPaymentPagedQueryResponseQueryBuilderDsl
    {
        public MyPaymentPagedQueryResponseQueryBuilderDsl()
        {
        }

        public static MyPaymentPagedQueryResponseQueryBuilderDsl Of()
        {
            return new MyPaymentPagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyPaymentPagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<MyPaymentPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<MyPaymentPagedQueryResponseQueryBuilderDsl>(p, MyPaymentPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyPaymentPagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<MyPaymentPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<MyPaymentPagedQueryResponseQueryBuilderDsl>(p, MyPaymentPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyPaymentPagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<MyPaymentPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<MyPaymentPagedQueryResponseQueryBuilderDsl>(p, MyPaymentPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyPaymentPagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<MyPaymentPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<MyPaymentPagedQueryResponseQueryBuilderDsl>(p, MyPaymentPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyPaymentPagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyPaymentQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyPaymentQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyPaymentPagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyPaymentQueryBuilderDsl.Of())),
                MyPaymentPagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<MyPaymentPagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<MyPaymentPagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<MyPaymentPagedQueryResponseQueryBuilderDsl>(p, MyPaymentPagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
