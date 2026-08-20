using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartSetEstimatedDeliveryActionQueryBuilderDsl
    {
        public CartSetEstimatedDeliveryActionQueryBuilderDsl()
        {
        }

        public static CartSetEstimatedDeliveryActionQueryBuilderDsl Of()
        {
            return new CartSetEstimatedDeliveryActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartSetEstimatedDeliveryActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartSetEstimatedDeliveryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartSetEstimatedDeliveryActionQueryBuilderDsl>(p, CartSetEstimatedDeliveryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetEstimatedDeliveryActionQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<CartSetEstimatedDeliveryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<CartSetEstimatedDeliveryActionQueryBuilderDsl>(p, CartSetEstimatedDeliveryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartSetEstimatedDeliveryActionQueryBuilderDsl> EstimatedDelivery(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.EstimatedDeliveryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.EstimatedDeliveryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartSetEstimatedDeliveryActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("estimatedDelivery"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.EstimatedDeliveryQueryBuilderDsl.Of())),
                CartSetEstimatedDeliveryActionQueryBuilderDsl.Of);
        }


    }
}
