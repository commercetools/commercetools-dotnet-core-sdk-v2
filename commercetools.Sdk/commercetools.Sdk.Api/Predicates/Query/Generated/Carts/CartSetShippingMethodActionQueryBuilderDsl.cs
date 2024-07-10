using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartSetShippingMethodActionQueryBuilderDsl
    {
        public CartSetShippingMethodActionQueryBuilderDsl()
        {
        }

        public static CartSetShippingMethodActionQueryBuilderDsl Of()
        {
            return new CartSetShippingMethodActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartSetShippingMethodActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartSetShippingMethodActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartSetShippingMethodActionQueryBuilderDsl>(p, CartSetShippingMethodActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartSetShippingMethodActionQueryBuilderDsl> ShippingMethod(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartSetShippingMethodActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingMethod"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodResourceIdentifierQueryBuilderDsl.Of())),
                CartSetShippingMethodActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartSetShippingMethodActionQueryBuilderDsl> ExternalTaxRate(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartSetShippingMethodActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalTaxRate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl.Of())),
                CartSetShippingMethodActionQueryBuilderDsl.Of);
        }


    }
}
