using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class PaymentInfoQueryBuilderDsl
    {
        public PaymentInfoQueryBuilderDsl()
        {
        }

        public static PaymentInfoQueryBuilderDsl Of()
        {
            return new PaymentInfoQueryBuilderDsl();
        }

        public CombinationQueryPredicate<PaymentInfoQueryBuilderDsl> Payments(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentInfoQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("payments"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentReferenceQueryBuilderDsl.Of())),
                PaymentInfoQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<PaymentInfoQueryBuilderDsl> Payments()
        {
            return new CollectionPredicateBuilder<PaymentInfoQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("payments")),
                    p => new CombinationQueryPredicate<PaymentInfoQueryBuilderDsl>(p, PaymentInfoQueryBuilderDsl.Of));
        }

    }
}
