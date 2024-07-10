using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShippingMethods
{

    public partial class ShippingMethodAddShippingRateActionQueryBuilderDsl
    {
        public ShippingMethodAddShippingRateActionQueryBuilderDsl()
        {
        }

        public static ShippingMethodAddShippingRateActionQueryBuilderDsl Of()
        {
            return new ShippingMethodAddShippingRateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShippingMethodAddShippingRateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShippingMethodAddShippingRateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShippingMethodAddShippingRateActionQueryBuilderDsl>(p, ShippingMethodAddShippingRateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShippingMethodAddShippingRateActionQueryBuilderDsl> Zone(
            Func<commercetools.Sdk.Api.Predicates.Query.Zones.ZoneResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Zones.ZoneResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodAddShippingRateActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("zone"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Zones.ZoneResourceIdentifierQueryBuilderDsl.Of())),
                ShippingMethodAddShippingRateActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShippingMethodAddShippingRateActionQueryBuilderDsl> ShippingRate(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingRateDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingRateDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodAddShippingRateActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingRate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingRateDraftQueryBuilderDsl.Of())),
                ShippingMethodAddShippingRateActionQueryBuilderDsl.Of);
        }


    }
}
