using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Zones
{

    public partial class ZoneDraftQueryBuilderDsl
    {
        public ZoneDraftQueryBuilderDsl()
        {
        }

        public static ZoneDraftQueryBuilderDsl Of()
        {
            return new ZoneDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ZoneDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ZoneDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ZoneDraftQueryBuilderDsl>(p, ZoneDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ZoneDraftQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ZoneDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ZoneDraftQueryBuilderDsl>(p, ZoneDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ZoneDraftQueryBuilderDsl, string> Description()
        {
            return new ComparisonPredicateBuilder<ZoneDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("description")),
            p => new CombinationQueryPredicate<ZoneDraftQueryBuilderDsl>(p, ZoneDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ZoneDraftQueryBuilderDsl> Locations(
            Func<commercetools.Sdk.Api.Predicates.Query.Zones.LocationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Zones.LocationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ZoneDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("locations"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Zones.LocationQueryBuilderDsl.Of())),
                ZoneDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ZoneDraftQueryBuilderDsl> Locations()
        {
            return new CollectionPredicateBuilder<ZoneDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("locations")),
                    p => new CombinationQueryPredicate<ZoneDraftQueryBuilderDsl>(p, ZoneDraftQueryBuilderDsl.Of));
        }

    }
}
