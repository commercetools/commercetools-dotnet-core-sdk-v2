using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Payments
{

    public partial class PaymentPagedQueryResponseQueryBuilderDsl
    {
        public PaymentPagedQueryResponseQueryBuilderDsl()
        {
        }

        public static PaymentPagedQueryResponseQueryBuilderDsl Of()
        {
            return new PaymentPagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentPagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<PaymentPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<PaymentPagedQueryResponseQueryBuilderDsl>(p, PaymentPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentPagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<PaymentPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<PaymentPagedQueryResponseQueryBuilderDsl>(p, PaymentPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentPagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<PaymentPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<PaymentPagedQueryResponseQueryBuilderDsl>(p, PaymentPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentPagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<PaymentPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<PaymentPagedQueryResponseQueryBuilderDsl>(p, PaymentPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentPagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentPagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentQueryBuilderDsl.Of())),
                PaymentPagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<PaymentPagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<PaymentPagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<PaymentPagedQueryResponseQueryBuilderDsl>(p, PaymentPagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
