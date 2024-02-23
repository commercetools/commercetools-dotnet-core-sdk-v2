using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class DeliveryRemovedMessagePayloadQueryBuilderDsl
    {
        public DeliveryRemovedMessagePayloadQueryBuilderDsl()
        {
        }

        public static DeliveryRemovedMessagePayloadQueryBuilderDsl Of()
        {
            return new DeliveryRemovedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DeliveryRemovedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<DeliveryRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<DeliveryRemovedMessagePayloadQueryBuilderDsl>(p, DeliveryRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DeliveryRemovedMessagePayloadQueryBuilderDsl> Delivery(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DeliveryRemovedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("delivery"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryQueryBuilderDsl.Of())),
                DeliveryRemovedMessagePayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<DeliveryRemovedMessagePayloadQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<DeliveryRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<DeliveryRemovedMessagePayloadQueryBuilderDsl>(p, DeliveryRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
