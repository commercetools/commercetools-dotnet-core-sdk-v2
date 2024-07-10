using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetShippingMethodActionQueryBuilderDsl
    {
        public StagedOrderSetShippingMethodActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetShippingMethodActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetShippingMethodActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetShippingMethodActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetShippingMethodActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetShippingMethodActionQueryBuilderDsl>(p, StagedOrderSetShippingMethodActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderSetShippingMethodActionQueryBuilderDsl> ShippingMethod(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderSetShippingMethodActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingMethod"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodResourceIdentifierQueryBuilderDsl.Of())),
                StagedOrderSetShippingMethodActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedOrderSetShippingMethodActionQueryBuilderDsl> ExternalTaxRate(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderSetShippingMethodActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalTaxRate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl.Of())),
                StagedOrderSetShippingMethodActionQueryBuilderDsl.Of);
        }


    }
}
