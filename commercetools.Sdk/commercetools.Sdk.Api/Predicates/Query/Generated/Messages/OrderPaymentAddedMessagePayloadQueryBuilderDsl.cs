using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

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
        public CombinationQueryPredicate<OrderPaymentAddedMessagePayloadQueryBuilderDsl> Payment(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderPaymentAddedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("payment"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentReferenceQueryBuilderDsl.Of())),
                OrderPaymentAddedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
