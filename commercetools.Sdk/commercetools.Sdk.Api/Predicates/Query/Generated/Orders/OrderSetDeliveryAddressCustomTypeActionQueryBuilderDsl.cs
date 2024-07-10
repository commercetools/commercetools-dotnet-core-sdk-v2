using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSetDeliveryAddressCustomTypeActionQueryBuilderDsl
    {
        public OrderSetDeliveryAddressCustomTypeActionQueryBuilderDsl()
        {
        }

        public static OrderSetDeliveryAddressCustomTypeActionQueryBuilderDsl Of()
        {
            return new OrderSetDeliveryAddressCustomTypeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSetDeliveryAddressCustomTypeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderSetDeliveryAddressCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderSetDeliveryAddressCustomTypeActionQueryBuilderDsl>(p, OrderSetDeliveryAddressCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetDeliveryAddressCustomTypeActionQueryBuilderDsl, string> DeliveryId()
        {
            return new ComparisonPredicateBuilder<OrderSetDeliveryAddressCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryId")),
            p => new CombinationQueryPredicate<OrderSetDeliveryAddressCustomTypeActionQueryBuilderDsl>(p, OrderSetDeliveryAddressCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetDeliveryAddressCustomTypeActionQueryBuilderDsl, string> DeliveryKey()
        {
            return new ComparisonPredicateBuilder<OrderSetDeliveryAddressCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryKey")),
            p => new CombinationQueryPredicate<OrderSetDeliveryAddressCustomTypeActionQueryBuilderDsl>(p, OrderSetDeliveryAddressCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderSetDeliveryAddressCustomTypeActionQueryBuilderDsl> Type(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSetDeliveryAddressCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("type"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl.Of())),
                OrderSetDeliveryAddressCustomTypeActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderSetDeliveryAddressCustomTypeActionQueryBuilderDsl> Fields(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSetDeliveryAddressCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fields"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl.Of())),
                OrderSetDeliveryAddressCustomTypeActionQueryBuilderDsl.Of);
        }


    }
}
