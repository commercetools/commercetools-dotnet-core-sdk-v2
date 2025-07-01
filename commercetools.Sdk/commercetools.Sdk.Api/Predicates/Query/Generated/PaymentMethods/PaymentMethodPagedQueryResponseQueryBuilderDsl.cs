using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.PaymentMethods
{

    public partial class PaymentMethodPagedQueryResponseQueryBuilderDsl
    {
        public PaymentMethodPagedQueryResponseQueryBuilderDsl()
        {
        }

        public static PaymentMethodPagedQueryResponseQueryBuilderDsl Of()
        {
            return new PaymentMethodPagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentMethodPagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<PaymentMethodPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<PaymentMethodPagedQueryResponseQueryBuilderDsl>(p, PaymentMethodPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodPagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<PaymentMethodPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<PaymentMethodPagedQueryResponseQueryBuilderDsl>(p, PaymentMethodPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodPagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<PaymentMethodPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<PaymentMethodPagedQueryResponseQueryBuilderDsl>(p, PaymentMethodPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodPagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<PaymentMethodPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<PaymentMethodPagedQueryResponseQueryBuilderDsl>(p, PaymentMethodPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentMethodPagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentMethodPagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodQueryBuilderDsl.Of())),
                PaymentMethodPagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<PaymentMethodPagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<PaymentMethodPagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<PaymentMethodPagedQueryResponseQueryBuilderDsl>(p, PaymentMethodPagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
