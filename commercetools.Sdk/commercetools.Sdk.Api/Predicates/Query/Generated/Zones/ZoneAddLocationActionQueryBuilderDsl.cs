using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Zones
{

    public partial class ZoneAddLocationActionQueryBuilderDsl
    {
        public ZoneAddLocationActionQueryBuilderDsl()
        {
        }

        public static ZoneAddLocationActionQueryBuilderDsl Of()
        {
            return new ZoneAddLocationActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ZoneAddLocationActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ZoneAddLocationActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ZoneAddLocationActionQueryBuilderDsl>(p, ZoneAddLocationActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ZoneAddLocationActionQueryBuilderDsl> Location(
            Func<commercetools.Sdk.Api.Predicates.Query.Zones.LocationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Zones.LocationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ZoneAddLocationActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("location"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Zones.LocationQueryBuilderDsl.Of())),
                ZoneAddLocationActionQueryBuilderDsl.Of);
        }


    }
}
