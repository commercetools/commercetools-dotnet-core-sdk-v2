using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSetEstimatedDeliveryActionQueryBuilderDsl
    {
        public OrderSetEstimatedDeliveryActionQueryBuilderDsl()
        {
        }

        public static OrderSetEstimatedDeliveryActionQueryBuilderDsl Of()
        {
            return new OrderSetEstimatedDeliveryActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSetEstimatedDeliveryActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderSetEstimatedDeliveryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderSetEstimatedDeliveryActionQueryBuilderDsl>(p, OrderSetEstimatedDeliveryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetEstimatedDeliveryActionQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<OrderSetEstimatedDeliveryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<OrderSetEstimatedDeliveryActionQueryBuilderDsl>(p, OrderSetEstimatedDeliveryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderSetEstimatedDeliveryActionQueryBuilderDsl> EstimatedDelivery(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.EstimatedDeliveryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.EstimatedDeliveryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSetEstimatedDeliveryActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("estimatedDelivery"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.EstimatedDeliveryQueryBuilderDsl.Of())),
                OrderSetEstimatedDeliveryActionQueryBuilderDsl.Of);
        }


    }
}
