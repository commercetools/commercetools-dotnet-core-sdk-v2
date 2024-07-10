using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShippingMethods
{

    public partial class ShippingMethodRemoveZoneActionQueryBuilderDsl
    {
        public ShippingMethodRemoveZoneActionQueryBuilderDsl()
        {
        }

        public static ShippingMethodRemoveZoneActionQueryBuilderDsl Of()
        {
            return new ShippingMethodRemoveZoneActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShippingMethodRemoveZoneActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShippingMethodRemoveZoneActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShippingMethodRemoveZoneActionQueryBuilderDsl>(p, ShippingMethodRemoveZoneActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShippingMethodRemoveZoneActionQueryBuilderDsl> Zone(
            Func<commercetools.Sdk.Api.Predicates.Query.Zones.ZoneResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Zones.ZoneResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodRemoveZoneActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("zone"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Zones.ZoneResourceIdentifierQueryBuilderDsl.Of())),
                ShippingMethodRemoveZoneActionQueryBuilderDsl.Of);
        }


    }
}
