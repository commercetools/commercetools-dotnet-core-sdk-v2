using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShippingMethods
{

    public partial class ShippingMethodRemoveShippingRateActionQueryBuilderDsl
    {
        public ShippingMethodRemoveShippingRateActionQueryBuilderDsl()
        {
        }

        public static ShippingMethodRemoveShippingRateActionQueryBuilderDsl Of()
        {
            return new ShippingMethodRemoveShippingRateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShippingMethodRemoveShippingRateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShippingMethodRemoveShippingRateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShippingMethodRemoveShippingRateActionQueryBuilderDsl>(p, ShippingMethodRemoveShippingRateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShippingMethodRemoveShippingRateActionQueryBuilderDsl> Zone(
            Func<commercetools.Sdk.Api.Predicates.Query.Zones.ZoneResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Zones.ZoneResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodRemoveShippingRateActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("zone"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Zones.ZoneResourceIdentifierQueryBuilderDsl.Of())),
                ShippingMethodRemoveShippingRateActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShippingMethodRemoveShippingRateActionQueryBuilderDsl> ShippingRate(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingRateDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingRateDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodRemoveShippingRateActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shippingRate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingRateDraftQueryBuilderDsl.Of())),
                ShippingMethodRemoveShippingRateActionQueryBuilderDsl.Of);
        }


    }
}
