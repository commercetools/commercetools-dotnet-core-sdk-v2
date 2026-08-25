using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CartEstimatedDeliverySetMessagePayloadQueryBuilderDsl
    {
        public CartEstimatedDeliverySetMessagePayloadQueryBuilderDsl()
        {
        }

        public static CartEstimatedDeliverySetMessagePayloadQueryBuilderDsl Of()
        {
            return new CartEstimatedDeliverySetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartEstimatedDeliverySetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CartEstimatedDeliverySetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CartEstimatedDeliverySetMessagePayloadQueryBuilderDsl>(p, CartEstimatedDeliverySetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartEstimatedDeliverySetMessagePayloadQueryBuilderDsl> EstimatedDelivery(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.EstimatedDeliveryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.EstimatedDeliveryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartEstimatedDeliverySetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("estimatedDelivery"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.EstimatedDeliveryQueryBuilderDsl.Of())),
                CartEstimatedDeliverySetMessagePayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CartEstimatedDeliverySetMessagePayloadQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<CartEstimatedDeliverySetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<CartEstimatedDeliverySetMessagePayloadQueryBuilderDsl>(p, CartEstimatedDeliverySetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
