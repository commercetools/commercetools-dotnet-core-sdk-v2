using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Zones
{

    public partial class ZoneRemoveLocationActionQueryBuilderDsl
    {
        public ZoneRemoveLocationActionQueryBuilderDsl()
        {
        }

        public static ZoneRemoveLocationActionQueryBuilderDsl Of()
        {
            return new ZoneRemoveLocationActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ZoneRemoveLocationActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ZoneRemoveLocationActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ZoneRemoveLocationActionQueryBuilderDsl>(p, ZoneRemoveLocationActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ZoneRemoveLocationActionQueryBuilderDsl> Location(
            Func<commercetools.Sdk.Api.Predicates.Query.Zones.LocationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Zones.LocationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ZoneRemoveLocationActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("location"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Zones.LocationQueryBuilderDsl.Of())),
                ZoneRemoveLocationActionQueryBuilderDsl.Of);
        }


    }
}
