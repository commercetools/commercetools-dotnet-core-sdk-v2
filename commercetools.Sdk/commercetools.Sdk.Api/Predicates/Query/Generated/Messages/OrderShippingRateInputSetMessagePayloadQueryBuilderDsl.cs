using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderShippingRateInputSetMessagePayloadQueryBuilderDsl
    {
        public OrderShippingRateInputSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static OrderShippingRateInputSetMessagePayloadQueryBuilderDsl Of()
        {
            return new OrderShippingRateInputSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderShippingRateInputSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderShippingRateInputSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderShippingRateInputSetMessagePayloadQueryBuilderDsl>(p, OrderShippingRateInputSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderShippingRateInputSetMessagePayloadQueryBuilderDsl> ShippingRateInput(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingRateInputQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingRateInputQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderShippingRateInputSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingRateInput"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ShippingRateInputQueryBuilderDsl.Of())),
                OrderShippingRateInputSetMessagePayloadQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderShippingRateInputSetMessagePayloadQueryBuilderDsl> OldShippingRateInput(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingRateInputQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ShippingRateInputQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderShippingRateInputSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("oldShippingRateInput"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ShippingRateInputQueryBuilderDsl.Of())),
                OrderShippingRateInputSetMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
