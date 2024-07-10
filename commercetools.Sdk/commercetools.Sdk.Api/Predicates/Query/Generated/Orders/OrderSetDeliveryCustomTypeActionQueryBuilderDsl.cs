using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSetDeliveryCustomTypeActionQueryBuilderDsl
    {
        public OrderSetDeliveryCustomTypeActionQueryBuilderDsl()
        {
        }

        public static OrderSetDeliveryCustomTypeActionQueryBuilderDsl Of()
        {
            return new OrderSetDeliveryCustomTypeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSetDeliveryCustomTypeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderSetDeliveryCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderSetDeliveryCustomTypeActionQueryBuilderDsl>(p, OrderSetDeliveryCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetDeliveryCustomTypeActionQueryBuilderDsl, string> DeliveryId()
        {
            return new ComparisonPredicateBuilder<OrderSetDeliveryCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryId")),
            p => new CombinationQueryPredicate<OrderSetDeliveryCustomTypeActionQueryBuilderDsl>(p, OrderSetDeliveryCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetDeliveryCustomTypeActionQueryBuilderDsl, string> DeliveryKey()
        {
            return new ComparisonPredicateBuilder<OrderSetDeliveryCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryKey")),
            p => new CombinationQueryPredicate<OrderSetDeliveryCustomTypeActionQueryBuilderDsl>(p, OrderSetDeliveryCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderSetDeliveryCustomTypeActionQueryBuilderDsl> Type(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSetDeliveryCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("type"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl.Of())),
                OrderSetDeliveryCustomTypeActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderSetDeliveryCustomTypeActionQueryBuilderDsl> Fields(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSetDeliveryCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fields"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl.Of())),
                OrderSetDeliveryCustomTypeActionQueryBuilderDsl.Of);
        }


    }
}
