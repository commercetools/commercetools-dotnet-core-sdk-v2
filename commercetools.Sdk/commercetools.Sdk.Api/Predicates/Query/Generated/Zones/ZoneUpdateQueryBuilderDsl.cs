using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Zones
{

    public partial class ZoneUpdateQueryBuilderDsl
    {
        public ZoneUpdateQueryBuilderDsl()
        {
        }

        public static ZoneUpdateQueryBuilderDsl Of()
        {
            return new ZoneUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ZoneUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ZoneUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ZoneUpdateQueryBuilderDsl>(p, ZoneUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ZoneUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.Zones.ZoneUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Zones.ZoneUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ZoneUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Zones.ZoneUpdateActionQueryBuilderDsl.Of())),
                ZoneUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ZoneUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<ZoneUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<ZoneUpdateQueryBuilderDsl>(p, ZoneUpdateQueryBuilderDsl.Of));
        }

    }
}
