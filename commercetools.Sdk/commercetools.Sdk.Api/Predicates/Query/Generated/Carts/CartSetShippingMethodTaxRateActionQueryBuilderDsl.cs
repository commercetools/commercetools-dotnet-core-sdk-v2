using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartSetShippingMethodTaxRateActionQueryBuilderDsl
    {
        public CartSetShippingMethodTaxRateActionQueryBuilderDsl()
        {
        }

        public static CartSetShippingMethodTaxRateActionQueryBuilderDsl Of()
        {
            return new CartSetShippingMethodTaxRateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartSetShippingMethodTaxRateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartSetShippingMethodTaxRateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartSetShippingMethodTaxRateActionQueryBuilderDsl>(p, CartSetShippingMethodTaxRateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetShippingMethodTaxRateActionQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<CartSetShippingMethodTaxRateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<CartSetShippingMethodTaxRateActionQueryBuilderDsl>(p, CartSetShippingMethodTaxRateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartSetShippingMethodTaxRateActionQueryBuilderDsl> ExternalTaxRate(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartSetShippingMethodTaxRateActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalTaxRate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl.Of())),
                CartSetShippingMethodTaxRateActionQueryBuilderDsl.Of);
        }


    }
}
