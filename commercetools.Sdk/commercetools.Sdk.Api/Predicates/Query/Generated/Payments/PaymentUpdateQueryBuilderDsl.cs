using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Payments
{

    public partial class PaymentUpdateQueryBuilderDsl
    {
        public PaymentUpdateQueryBuilderDsl()
        {
        }

        public static PaymentUpdateQueryBuilderDsl Of()
        {
            return new PaymentUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<PaymentUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<PaymentUpdateQueryBuilderDsl>(p, PaymentUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentUpdateActionQueryBuilderDsl.Of())),
                PaymentUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<PaymentUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<PaymentUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<PaymentUpdateQueryBuilderDsl>(p, PaymentUpdateQueryBuilderDsl.Of));
        }

    }
}
