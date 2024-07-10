using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSetDeliveryAddressActionQueryBuilderDsl
    {
        public OrderSetDeliveryAddressActionQueryBuilderDsl()
        {
        }

        public static OrderSetDeliveryAddressActionQueryBuilderDsl Of()
        {
            return new OrderSetDeliveryAddressActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSetDeliveryAddressActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderSetDeliveryAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderSetDeliveryAddressActionQueryBuilderDsl>(p, OrderSetDeliveryAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetDeliveryAddressActionQueryBuilderDsl, string> DeliveryId()
        {
            return new ComparisonPredicateBuilder<OrderSetDeliveryAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryId")),
            p => new CombinationQueryPredicate<OrderSetDeliveryAddressActionQueryBuilderDsl>(p, OrderSetDeliveryAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetDeliveryAddressActionQueryBuilderDsl, string> DeliveryKey()
        {
            return new ComparisonPredicateBuilder<OrderSetDeliveryAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryKey")),
            p => new CombinationQueryPredicate<OrderSetDeliveryAddressActionQueryBuilderDsl>(p, OrderSetDeliveryAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderSetDeliveryAddressActionQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSetDeliveryAddressActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                OrderSetDeliveryAddressActionQueryBuilderDsl.Of);
        }


    }
}
