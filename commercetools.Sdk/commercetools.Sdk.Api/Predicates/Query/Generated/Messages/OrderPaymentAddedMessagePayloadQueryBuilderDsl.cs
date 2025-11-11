using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderPaymentAddedMessagePayloadQueryBuilderDsl
    {
        public OrderPaymentAddedMessagePayloadQueryBuilderDsl()
        {
        }

        public static OrderPaymentAddedMessagePayloadQueryBuilderDsl Of()
        {
            return new OrderPaymentAddedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderPaymentAddedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderPaymentAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderPaymentAddedMessagePayloadQueryBuilderDsl>(p, OrderPaymentAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderPaymentAddedMessagePayloadQueryBuilderDsl> PaymentRef(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderPaymentAddedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("paymentRef"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentReferenceQueryBuilderDsl.Of())),
                OrderPaymentAddedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
