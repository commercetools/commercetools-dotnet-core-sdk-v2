using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderShippingInfoSetMessagePayloadQueryBuilderDsl
    {
        public OrderShippingInfoSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static OrderShippingInfoSetMessagePayloadQueryBuilderDsl Of()
        {
            return new OrderShippingInfoSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderShippingInfoSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderShippingInfoSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderShippingInfoSetMessagePayloadQueryBuilderDsl>(p, OrderShippingInfoSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderShippingInfoSetMessagePayloadQueryBuilderDsl> ShippingInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingInfoQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingInfoQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderShippingInfoSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingInfo"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ShippingInfoQueryBuilderDsl.Of())),
                OrderShippingInfoSetMessagePayloadQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderShippingInfoSetMessagePayloadQueryBuilderDsl> OldShippingInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingInfoQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingInfoQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderShippingInfoSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("oldShippingInfo"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ShippingInfoQueryBuilderDsl.Of())),
                OrderShippingInfoSetMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
