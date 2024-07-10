using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class DeliveryAddedMessagePayloadQueryBuilderDsl
    {
        public DeliveryAddedMessagePayloadQueryBuilderDsl()
        {
        }

        public static DeliveryAddedMessagePayloadQueryBuilderDsl Of()
        {
            return new DeliveryAddedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DeliveryAddedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<DeliveryAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<DeliveryAddedMessagePayloadQueryBuilderDsl>(p, DeliveryAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DeliveryAddedMessagePayloadQueryBuilderDsl> Delivery(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DeliveryAddedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("delivery"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.DeliveryQueryBuilderDsl.Of())),
                DeliveryAddedMessagePayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<DeliveryAddedMessagePayloadQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<DeliveryAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<DeliveryAddedMessagePayloadQueryBuilderDsl>(p, DeliveryAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
