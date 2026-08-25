using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderEstimatedDeliverySetMessagePayloadQueryBuilderDsl
    {
        public OrderEstimatedDeliverySetMessagePayloadQueryBuilderDsl()
        {
        }

        public static OrderEstimatedDeliverySetMessagePayloadQueryBuilderDsl Of()
        {
            return new OrderEstimatedDeliverySetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderEstimatedDeliverySetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderEstimatedDeliverySetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderEstimatedDeliverySetMessagePayloadQueryBuilderDsl>(p, OrderEstimatedDeliverySetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderEstimatedDeliverySetMessagePayloadQueryBuilderDsl> EstimatedDelivery(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.EstimatedDeliveryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.EstimatedDeliveryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEstimatedDeliverySetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("estimatedDelivery"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.EstimatedDeliveryQueryBuilderDsl.Of())),
                OrderEstimatedDeliverySetMessagePayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderEstimatedDeliverySetMessagePayloadQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<OrderEstimatedDeliverySetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<OrderEstimatedDeliverySetMessagePayloadQueryBuilderDsl>(p, OrderEstimatedDeliverySetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
