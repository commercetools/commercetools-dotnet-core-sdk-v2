using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Zones
{

    public partial class ZoneQueryBuilderDsl
    {
        public ZoneQueryBuilderDsl()
        {
        }

        public static ZoneQueryBuilderDsl Of()
        {
            return new ZoneQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ZoneQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ZoneQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ZoneQueryBuilderDsl>(p, ZoneQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ZoneQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ZoneQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ZoneQueryBuilderDsl>(p, ZoneQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ZoneQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ZoneQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ZoneQueryBuilderDsl>(p, ZoneQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ZoneQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<ZoneQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<ZoneQueryBuilderDsl>(p, ZoneQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ZoneQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ZoneQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                ZoneQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ZoneQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ZoneQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                ZoneQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ZoneQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ZoneQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ZoneQueryBuilderDsl>(p, ZoneQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ZoneQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ZoneQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ZoneQueryBuilderDsl>(p, ZoneQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ZoneQueryBuilderDsl, string> Description()
        {
            return new ComparisonPredicateBuilder<ZoneQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("description")),
            p => new CombinationQueryPredicate<ZoneQueryBuilderDsl>(p, ZoneQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ZoneQueryBuilderDsl> Locations(
            Func<commercetools.Sdk.Api.Predicates.Query.Zones.LocationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Zones.LocationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ZoneQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("locations"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Zones.LocationQueryBuilderDsl.Of())),
                ZoneQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ZoneQueryBuilderDsl> Locations()
        {
            return new CollectionPredicateBuilder<ZoneQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("locations")),
                    p => new CombinationQueryPredicate<ZoneQueryBuilderDsl>(p, ZoneQueryBuilderDsl.Of));
        }

    }
}
