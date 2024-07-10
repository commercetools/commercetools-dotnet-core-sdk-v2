using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetShippingMethodTaxRateActionQueryBuilderDsl
    {
        public StagedOrderSetShippingMethodTaxRateActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetShippingMethodTaxRateActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetShippingMethodTaxRateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetShippingMethodTaxRateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetShippingMethodTaxRateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetShippingMethodTaxRateActionQueryBuilderDsl>(p, StagedOrderSetShippingMethodTaxRateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetShippingMethodTaxRateActionQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetShippingMethodTaxRateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<StagedOrderSetShippingMethodTaxRateActionQueryBuilderDsl>(p, StagedOrderSetShippingMethodTaxRateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderSetShippingMethodTaxRateActionQueryBuilderDsl> ExternalTaxRate(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderSetShippingMethodTaxRateActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalTaxRate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.ExternalTaxRateDraftQueryBuilderDsl.Of())),
                StagedOrderSetShippingMethodTaxRateActionQueryBuilderDsl.Of);
        }


    }
}
