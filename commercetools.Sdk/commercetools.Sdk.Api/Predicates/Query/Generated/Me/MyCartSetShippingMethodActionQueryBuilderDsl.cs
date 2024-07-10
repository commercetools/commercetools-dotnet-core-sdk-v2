using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCartSetShippingMethodActionQueryBuilderDsl
    {
        public MyCartSetShippingMethodActionQueryBuilderDsl()
        {
        }

        public static MyCartSetShippingMethodActionQueryBuilderDsl Of()
        {
            return new MyCartSetShippingMethodActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCartSetShippingMethodActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCartSetShippingMethodActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCartSetShippingMethodActionQueryBuilderDsl>(p, MyCartSetShippingMethodActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyCartSetShippingMethodActionQueryBuilderDsl> ShippingMethod(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartSetShippingMethodActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingMethod"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodResourceIdentifierQueryBuilderDsl.Of())),
                MyCartSetShippingMethodActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<MyCartSetShippingMethodActionQueryBuilderDsl> ExternalTaxRate(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartSetShippingMethodActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalTaxRate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl.Of())),
                MyCartSetShippingMethodActionQueryBuilderDsl.Of);
        }


    }
}
