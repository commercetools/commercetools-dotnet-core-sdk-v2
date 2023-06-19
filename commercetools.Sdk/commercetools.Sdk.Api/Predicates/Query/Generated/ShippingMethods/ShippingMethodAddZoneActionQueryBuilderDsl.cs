using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShippingMethods
{

    public partial class ShippingMethodAddZoneActionQueryBuilderDsl
    {
        public ShippingMethodAddZoneActionQueryBuilderDsl()
        {
        }

        public static ShippingMethodAddZoneActionQueryBuilderDsl Of()
        {
            return new ShippingMethodAddZoneActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShippingMethodAddZoneActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShippingMethodAddZoneActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShippingMethodAddZoneActionQueryBuilderDsl>(p, ShippingMethodAddZoneActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShippingMethodAddZoneActionQueryBuilderDsl> Zone(
            Func<commercetools.Sdk.Api.Predicates.Query.Zones.ZoneResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Zones.ZoneResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodAddZoneActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("zone"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Zones.ZoneResourceIdentifierQueryBuilderDsl.Of())),
                ShippingMethodAddZoneActionQueryBuilderDsl.Of);
        }


    }
}
