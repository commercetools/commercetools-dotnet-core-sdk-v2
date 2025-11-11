using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderPaymentRemovedMessagePayloadQueryBuilderDsl
    {
        public OrderPaymentRemovedMessagePayloadQueryBuilderDsl()
        {
        }

        public static OrderPaymentRemovedMessagePayloadQueryBuilderDsl Of()
        {
            return new OrderPaymentRemovedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderPaymentRemovedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderPaymentRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderPaymentRemovedMessagePayloadQueryBuilderDsl>(p, OrderPaymentRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderPaymentRemovedMessagePayloadQueryBuilderDsl> PaymentRef(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderPaymentRemovedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("paymentRef"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentReferenceQueryBuilderDsl.Of())),
                OrderPaymentRemovedMessagePayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderPaymentRemovedMessagePayloadQueryBuilderDsl, bool> RemovedPaymentInfo()
        {
            return new ComparisonPredicateBuilder<OrderPaymentRemovedMessagePayloadQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("removedPaymentInfo")),
            p => new CombinationQueryPredicate<OrderPaymentRemovedMessagePayloadQueryBuilderDsl>(p, OrderPaymentRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
